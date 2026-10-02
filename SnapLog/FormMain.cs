using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SnapLog
{
    public partial class FormMain : Form
    {
        private double mosMin, mosMax, rosMin, rosMax;
        private PerformanceCounter cpu = new PerformanceCounter();
        private PC PCInfo = new PC();
        public static NetworkDiagnostics.NetworkDiagnostics NetDiags = new NetworkDiagnostics.NetworkDiagnostics();
        public static FormMain Instance { get; private set; }

        private formAbout _formAbout;
        private formConfig _formConfig;
        private FormHelp _formHelp;
        private FormLoadURL _formLoadURL;
        private FormTraceRoute _formTraceRoute;

        public FormMain()
        {
            InitializeComponent();
            Instance = this;
        }

        // form startup and close
        private void FormMain_Start(object sender, EventArgs e)
        {
            LoadUrlFile();

            try
            {
                cpu.CategoryName = "Processor";
                cpu.CounterName = "% Processor Time";
                cpu.InstanceName = "_Total";
                timerPCUtilization.Enabled = true;
            }
            catch
            {
                timerPCUtilization.Enabled = false;
            }

            UpdateSystemInfo();
            GetInstalledSoftware();
            GetVDIRegistry();
        }

        private void FormMain_Exit(object sender, FormClosingEventArgs e)
        {
            Ping ping = new Ping();
            ping.SendAsyncCancel();

            if (bgRunTrace.IsBusy) bgRunTrace.CancelAsync();
            if (bgMOSWorker.IsBusy) bgMOSWorker.CancelAsync();
            if (bgTelnet.IsBusy) bgTelnet.CancelAsync();
            if (bgInstalledSoftware.IsBusy) bgInstalledSoftware.CancelAsync();

            if (components != null)
            {
                components.Dispose();
            }
        }

        public void LoadUrlFile(string urlFile = "")
        {
            string[] args = Environment.GetCommandLineArgs().Skip(1).ToArray();
            List<string> urls = null;

            cboTarget.Items.Clear();

            if (string.IsNullOrEmpty(urlFile))
            {
                if (args.Length > 0)
                {
                    for (int i = 0; i < args.Length; i++)
                    {
                        switch (args[i])
                        {
                            case "-list":
                                if (i + 1 < args.Length && File.Exists(Path.Combine(Application.StartupPath, "remote", args[i + 1])))
                                {
                                    urls = Helpers.ImportTextFile(Path.Combine(Application.StartupPath, "remote", args[i + 1]));
                                }
                                else
                                {
                                    urls = Helpers.ImportTextFile(Path.Combine(Application.StartupPath, "remote", "Default.txt"));
                                }
                                break;

                            case "-hideloadbutton":
                                LoadURL.Visible = false;
                                break;
                        }
                    }
                }
                else
                {
                    urls = Helpers.ImportTextFile(Path.Combine(Application.StartupPath, "remote", "Default.txt"));
                }
            }
            else
            {
                if (File.Exists(urlFile))
                {
                    urls = Helpers.ImportTextFile(urlFile);
                }
                else
                {
                    urls = Helpers.ImportTextFile(Path.Combine(Application.StartupPath, "remote", "Default.txt"));
                }
            }

            if (urls != null)
            {
                foreach (var url in urls)
                {
                    if (!string.IsNullOrWhiteSpace(url))
                    {
                        cboTarget.Items.Add(url.ToString());
                    }
                }
            }

            cboTarget.Items.Add("www.google.com");
            cboTarget.Items.Add("8.8.8.8");
        }

        // form GO button events
        private void NetworkGoButton(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            IPAddress remoteIP = null;
            int remotePort = 80;

            #region RESET GUI And DATA

            // reset values
            mosMin = 0;
            mosMax = 0;
            rosMin = 0;
            rosMax = 0;
            PCInfo.ResetNetworkStats();

            // reset telnet GUI
            chkTelNetStatus.CheckState = CheckState.Unchecked;
            chkTelNetStatus.ForeColor = Color.Black;
            chkTelNetStatus.Text = "Telnet Busy";

            // reset variables
            txtLoss.Text = "0";
            txtJitter.Text = "0";
            txtAverageLatency.Text = "0";
            txtEffectiveLatency.Text = "0";

            lblPeakMOS.Text = "0";
            lblCurrentMOS.Text = "0";
            lblMinMOS.Text = "0";

            lblPeakRScore.Text = "0";
            lblCurrentRScore.Text = "0";
            lblMinRScore.Text = "0";

            #endregion

            #region VALIDATE TARGET

            // validate remote target
            if (string.IsNullOrEmpty(cboTarget.Text.Trim()))
            {
                return;
            }
            else
            {
                string targetText = cboTarget.Text.Replace("http://", "").Replace("https://", "");
                cboTarget.Text = targetText;

                if (targetText.Contains(":"))
                {
                    string[] parts = targetText.Trim().Split(':');
                    remoteIP = Helpers.GetRemoteIP(parts[0]);
                    int.TryParse(parts[1], out remotePort);
                }
                else
                {
                    remoteIP = Helpers.GetRemoteIP(targetText.Trim());
                }
            }

            if (remoteIP == null || remoteIP.ToString() == "0.0.0.0")
            {
                MessageBox.Show("You've entered an invalid URL or IP address ", "Invalid Target", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                NetDiags.IP = remoteIP;
                NetDiags.Port = remotePort;
            }

            if (NetDiags.IP.ToString() == "0.0.0.0")
            {
                MessageBox.Show("Unable To connect To remote host. Validate If the target entered Is correct.", "Unreachable Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblRemoteIP.Text = NetDiags.IP.ToString();

            #endregion

            #region PING LOOP
            ping.SendAsyncCancel();
            timerNetUtilization.Start();
            #endregion

            #region RUN TELNET
            if (bgTelnet.IsBusy) bgTelnet.CancelAsync();
            while (bgTelnet.IsBusy)
            {
                Application.DoEvents();
            }
            bgTelnet.RunWorkerAsync();
            #endregion

            #region RUN TRACEROUTE
            if (bgRunTrace.IsBusy) bgRunTrace.CancelAsync();
            while (bgRunTrace.IsBusy)
            {
                Application.DoEvents();
            }
            chkTraceRoute.Checked = false;
            bgRunTrace.RunWorkerAsync(NetDiags.IP);
            #endregion

            #region MOS SCORES LOOP
            if (bgMOSWorker.IsBusy) bgMOSWorker.CancelAsync();
            while (bgMOSWorker.IsBusy)
            {
                Application.DoEvents();
            }
            bgMOSWorker.RunWorkerAsync();
            #endregion

            tabNetwork.Cursor = Cursors.Default;
            cboTarget.Enabled = true;
            btnStart.Enabled = true;
            btnIPRefresh.Enabled = true;
        }

        // start ping procedures asynchronously
        private void AsyncPingTest()
        {
            AutoResetEvent waiter = new AutoResetEvent(false);
            byte[] data = Encoding.ASCII.GetBytes("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            int timeOut = 12000;
            Ping ping = new Ping();
            PingOptions pingOptions = new PingOptions(64, true);

            ping.PingCompleted += PingCompletedCallback;
            ping.SendAsync(NetDiags.IP, timeOut, data, pingOptions, waiter);
        }

        private void PingCompletedCallback(object sender, PingCompletedEventArgs e)
        {
            AutoResetEvent waiter = e.UserState as AutoResetEvent;

            if (e.Cancelled) MessageBox.Show("Ping cancelled", "Ping Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null) MessageBox.Show("Ping Error." + e.Error.Message, "Ping Status", MessageBoxButtons.OK, MessageBoxIcon.Error);

            PingReply reply = e.Reply;
            DisplayPingReply(reply);

            waiter?.Set();
        }

        private void DisplayPingReply(PingReply reply)
        {
            if (reply == null || reply.Address == null || reply.Address.ToString() == "0.0.0.0") return;

            lblPing.Text = "Ping response time To " + NetDiags.IP.ToString() + " Is " + reply.RoundtripTime + " milliseconds";
            lblRemoteIP.ForeColor = Color.Black;

            chartNetwork.Series["Ping Time"].Points.AddY(reply.RoundtripTime);
            if (chartNetwork.Series["Ping Time"].Points.Count > 10)
            {
                chartNetwork.ChartAreas[0].AxisX.ScaleView.Position = chartNetwork.Series["Ping Time"].Points.Count - 10;
                chartNetwork.ChartAreas[0].AxisX.ScaleView.Size = 10;
                chartNetwork.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
            }
        }

        // calculate MOS scores asynchronously
        private void NetworkDiagnostics_BUSY(object sender, DoWorkEventArgs e)
        {
            if (bgMOSWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            try
            {
                NetDiags.RunNetworkDiagnosticTest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MOS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NetworkDiagnostics_DONE(object sender, RunWorkerCompletedEventArgs e)
        {
            if (NetDiags.IP != null && NetDiags.IP.ToString() != "0.0.0.0")
            {
                PCInfo.NetworkStats = NetDiags.NetworkDiagnosticTestResult;

                try
                {
                    var stats = PCInfo.NetworkStats;
                    lblCurrentMOS.Text = stats.MOSScore.ToString("N5");
                    lblCurrentRScore.Text = stats.ROSScore.ToString("N5");

                    // set lowest MOS score
                    if (mosMin == 0 || stats.MOSScore < mosMin)
                    {
                        mosMin = stats.MOSScore;
                        lblMinMOS.Text = mosMin.ToString("N5");
                    }

                    // set peak MOS score
                    if (stats.MOSScore > mosMax)
                    {
                        mosMax = stats.MOSScore;
                        lblPeakMOS.Text = mosMax.ToString("N5");
                    }

                    // set lowest MOS R-Score
                    if (rosMin == 0 || stats.ROSScore < rosMin)
                    {
                        rosMin = stats.ROSScore;
                        lblMinRScore.Text = rosMin.ToString("N5");
                    }

                    // set peak MOS R-Score
                    if (stats.ROSScore > rosMax)
                    {
                        rosMax = stats.ROSScore;
                        lblPeakRScore.Text = rosMax.ToString("N5");
                    }

                    txtLoss.Text = (stats.PacketLossPercent * 100).ToString("N2") + "%";
                    txtAverageLatency.Text = stats.AverageLatency.ToString("N2") + " ms";
                    txtJitter.Text = stats.Jitter.ToString("N5");
                    txtEffectiveLatency.Text = stats.EffectiveLatency.ToString("N2") + " ms";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "MOS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!bgMOSWorker.IsBusy)
                {
                    bgMOSWorker.RunWorkerAsync();
                }
            }
        }

        // run trace route asynchronously
        private void RunTrace_BUSY(object sender, DoWorkEventArgs e)
        {
            IPAddress ip = e.Argument as IPAddress;

            if (bgRunTrace.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            try
            {
                NetDiags.RunTraceRoute(ip);
            }
            catch
            {
                if (lblTraceRoute.InvokeRequired)
                    lblTraceRoute.Invoke(new Action(() => lblTraceRoute.Text = "Trace Error"));
                else
                    lblTraceRoute.Text = "Trace Error";
            }
        }

        private void RunTrace_DONE(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                lblTraceRoute.Text = "Trace Completed";
                chkTraceRoute.Checked = true;
                PCInfo.TraceRouteData = NetDiags.TraceRouteResult;
            }
            catch
            {
                lblTraceRoute.Text = "Trace Error";
            }
        }

        // run telnet test asynchronously
        private void RunTelnet_BUSY(object sender, DoWorkEventArgs e)
        {
            if (bgTelnet.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            NetDiags.RunTelnet();
        }

        private void RunTelnet_DONE(object sender, RunWorkerCompletedEventArgs e)
        {
            if (NetDiags.TelnetResult)
            {
                chkTelNetStatus.CheckState = CheckState.Checked;
                chkTelNetStatus.ForeColor = Color.Green;
                chkTelNetStatus.Text = "Telnet Passed (" + NetDiags.Port + ")";
            }
            else
            {
                chkTelNetStatus.CheckState = CheckState.Indeterminate;
                chkTelNetStatus.ForeColor = Color.Red;
                chkTelNetStatus.Text = "Telnet Failed (" + NetDiags.Port + ")";
            }

            PCInfo.TelnetStatus = NetDiags.TelnetResult;
        }

        // load list of software installed asynchronously
        private void GetInstalledSoftware()
        {
            progressGetApps.Visible = true;
            listSoftware.Items.Clear();
            bgInstalledSoftware.RunWorkerAsync();
        }

        private void InstalledSoftware_BUSY(object sender, DoWorkEventArgs e)
        {
            List<string> sw = new List<string>();

            try
            {
                using (ManagementObjectSearcher moSearch = new ManagementObjectSearcher("Select * from Win32_Product"))
                using (ManagementObjectCollection moReturn = moSearch.Get())
                {
                    foreach (ManagementObject mo in moReturn)
                    {
                        if (mo != null && mo["Name"] != null)
                        {
                            sw.Add(mo["Name"].ToString());
                        }
                    }
                }
                e.Result = sw;
            }
            catch
            {
                e.Result = sw;
            }
        }

        private void InstalledSoftware_DONE(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is List<string> list)
            {
                foreach (string app in list)
                {
                    listSoftware.Items.Add(app.Trim());
                    PCInfo.InstalledApps.Add(app.Trim());
                }
            }
            progressGetApps.Visible = false;
        }

        // start 1-second timers
        private void TimerNetworkUtilization(object sender, EventArgs e)
        {
            if (PCInfo.NetworkDevices != null && PCInfo.NetworkDevices.Count > 0)
            {
                NetworkInterface networkDevice = PCInfo.NetworkDevices[0];
                IPv4InterfaceStatistics ipv4Stats = networkDevice.GetIPv4Statistics();

                double lastSent = 0;
                double lastRecv = 0;
                double.TryParse(txtBytesSent.Text, out lastSent);
                double.TryParse(txtBytesReceived.Text, out lastRecv);

                int bytesSent = (int)((ipv4Stats.BytesSent - lastSent) / 1024);
                int bytesReceived = (int)((ipv4Stats.BytesReceived - lastRecv) / 1024);

                if (NetDiags.IP != null && NetDiags.IP.ToString() != "0.0.0.0")
                {
                    AsyncPingTest();
                    txtBytesSent.Text = ipv4Stats.BytesSent.ToString();
                    txtBytesReceived.Text = ipv4Stats.BytesReceived.ToString();
                }
            }

            lblTraceRoute.Text = "Trace " + NetDiags.TraceRouteStatus;

            if (NetDiags.TraceRouteStatus == "Ongoing")
            {
                chkTraceRoute.Checked = false;
            }
            else
            {
                chkTraceRoute.Checked = true;
            }
        }

        private void TimerComputerUtilization(object sender, EventArgs e)
        {
            try
            {
                var compInfo = new Microsoft.VisualBasic.Devices.ComputerInfo();
                int memPct = (int)Math.Round(((double)(compInfo.TotalPhysicalMemory - compInfo.AvailablePhysicalMemory) / compInfo.TotalPhysicalMemory) * 100);
                int cpuPct = (int)Math.Round(cpu.NextValue());

                PCInfo.ProcUtilization = cpuPct;
                PCInfo.MemUtilization = memPct;

                ChartUtilization.Series["Memory"].Points.AddY(memPct);
                ChartUtilization.Series["Memory"].LegendText = "RAM - " + memPct + "% / " + PCInfo.TotalInstalledMemory + " GB";
                if (ChartUtilization.Series["Memory"].Points.Count > 10)
                {
                    ChartUtilization.ChartAreas[0].AxisX.ScaleView.Position = ChartUtilization.Series["Memory"].Points.Count - 10;
                    ChartUtilization.ChartAreas[0].AxisX.ScaleView.Size = 10;
                    ChartUtilization.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
                }

                ChartUtilization.Series["CPU"].Points.AddY(cpuPct);
                ChartUtilization.Series["CPU"].LegendText = "CPU - " + cpuPct + "%";
                if (ChartUtilization.Series["CPU"].Points.Count > 10)
                {
                    ChartUtilization.ChartAreas[0].AxisX.ScaleView.Position = ChartUtilization.Series["CPU"].Points.Count - 10;
                    ChartUtilization.ChartAreas[0].AxisX.ScaleView.Size = 10;
                    ChartUtilization.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " System utilization chart will temporarily be disabled.", "Performance Counter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timerPCUtilization.Enabled = false;
            }
        }

        // links to control panel
        private void LinkProgramsAndFeatures(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Control.exe", "/name Microsoft.ProgramsAndFeatures");
        }

        private void LinkWindowsUpdate(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Control.exe", "/name Microsoft.WindowsUpdate");
        }

        private void LinkDeviceManager(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Control.exe", "/name Microsoft.DeviceManager");
        }

        private void LinkNetworkSharingCenter(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Control.exe", "/name Microsoft.NetworkAndSharingCenter");
        }

        private void LinkInternetOptions(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Control.exe", "/name Microsoft.InternetOptions");
        }

        private void LinkUserAccounts(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Control.exe", "/name Microsoft.UserAccounts");
        }

        private void LinkTraceRoute(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_formTraceRoute == null || _formTraceRoute.IsDisposed)
            {
                _formTraceRoute = new FormTraceRoute();
            }
            _formTraceRoute.Show();
            _formTraceRoute.BringToFront();
        }

        // update system tab
        private void UpdateSystemInfo()
        {
            lblComputerName.Text = PCInfo.ComputerName;
            lblWindowsVersion.Text = PCInfo.WindowsVersion;
            lblWindowsArchitecture.Text = PCInfo.WindowsArchitecture;

            lblUsername.Text = PCInfo.Username;
            lblDomain.Text = PCInfo.Domain;
            lblLogonServer.Text = PCInfo.LogonServer;

            chkProxy.Checked = PCInfo.HasProxyEnabled();
            chkPAC.Checked = PCInfo.HasInternetAutoConfig();

            try
            {
                lblExternalIP.Text = PCInfo.ExternalIPAddress.ToString();
            }
            catch
            {
                MessageBox.Show("Error obtaining external IP address", "IP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblInternalIP1.Text = PCInfo.InternalIPAddress != null ? PCInfo.InternalIPAddress.ToString() : "";
            lblInternalIP2.Text = PCInfo.InternalIPAddress != null ? PCInfo.InternalIPAddress.ToString() : "";
            lblSubnetMask.Text = PCInfo.SubnetMask != null ? PCInfo.SubnetMask.ToString() : "";
            lblGatewayAddress.Text = PCInfo.GatewayAddress != null ? PCInfo.GatewayAddress.ToString() : "";
            lblDNS.Text = PCInfo.DNSAddress != null ? PCInfo.DNSAddress.ToString() : "";
        }

        // refresh network connection
        private void RefreshConnection(object sender, EventArgs e)
        {
            using (ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            using (ManagementObjectCollection objMOC = objMC.GetInstances())
            {
                if (MessageBox.Show("This procedure will refresh your connection And lose internet access momentarily. Continue?", "IP Refresh", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    foreach (ManagementObject objMO in objMOC)
                    {
                        objMO.InvokeMethod("ReleaseDHCPLease", null, null);
                        Thread.Sleep(3000);
                        objMO.InvokeMethod("RenewDHCPLease", null, null);
                    }

                    MessageBox.Show("Done refreshing network adapters.", "IP Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // refresh some tab on tab switch
        private void TabClick(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab == null) return;

            switch (tabMain.SelectedTab.Text)
            {
                case "System":
                    UpdateSystemInfo();
                    break;

                case "Software":
                    break;

                case "Network":
                    break;

                case "VDI":
                    GetVDIRegistry();
                    break;

                case "Scripts":
                    GetScripts();
                    break;
            }
        }

        // load VDI related registry keys
        private void GetVDIRegistry()
        {
            try
            {
                RegistryKey key = null;

                listVDIRegistry.Items.Clear();
                PCInfo.VDIRegistry.Clear();

                for (int i = 1; i <= 10; i++)
                {
                    key = Registry.CurrentUser.OpenSubKey(@"Volatile Environment\" + i.ToString());
                    if (key != null) break;
                }

                if (key != null)
                {
                    string[] keys = key.GetValueNames();

                    foreach (string k in keys)
                    {
                        string n = k;
                        string d = key.GetValue(k)?.ToString() ?? "";

                        PCInfo.VDIRegistry.Add(n + " = " + d);
                        listVDIRegistry.Items.Add(new ListViewItem(new string[] { n, d }));
                    }

                    key.Close();
                    listVDIRegistry.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                else
                {
                    MessageBox.Show("VDI related registry keys Not found.", "VDI Registry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading VDI values.\r\n" + ex.Message, "VDI Registry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RunGroupPolicy()
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (Properties.Settings.Default.GroupPolicy)
            {
                Helpers.RunCommand("gpresult.exe", desktop, "/H gpresult_export.html", false);
            }
        }

        private void GetScripts()
        {
            string scriptsDir = Path.Combine(Application.StartupPath, "scripts");
            listScripts.Items.Clear();

            if (Directory.Exists(scriptsDir))
            {
                DirectoryInfo di = new DirectoryInfo(scriptsDir);
                FileInfo[] diar1 = di.GetFiles("*.txt");

                foreach (FileInfo dra in diar1)
                {
                    listScripts.Items.Add(dra.Name.Replace(".txt", ""));
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (listScripts.SelectedItem != null)
            {
                string scriptName = listScripts.SelectedItem.ToString();
                string scriptPath = Path.Combine(Application.StartupPath, "scripts", scriptName + ".txt");
                if (File.Exists(scriptPath))
                {
                    ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", "/c \"" + scriptPath + "\"")
                    {
                        WorkingDirectory = Path.Combine(Application.StartupPath, "scripts"),
                        UseShellExecute = false
                    };
                    Process.Start(psi);
                }
            }
        }

        // show various forms
        private void ShowAbout(object sender, EventArgs e)
        {
            if (_formAbout == null || _formAbout.IsDisposed)
            {
                _formAbout = new formAbout();
            }
            _formAbout.Show();
            _formAbout.BringToFront();
        }

        private void ShowConfig(object sender, EventArgs e)
        {
            if (_formConfig == null || _formConfig.IsDisposed)
            {
                _formConfig = new formConfig();
            }
            _formConfig.Show();
            _formConfig.BringToFront();
        }

        private void ShowHelp(object sender, EventArgs e)
        {
            if (_formHelp == null || _formHelp.IsDisposed)
            {
                _formHelp = new FormHelp();
            }
            _formHelp.Show();
            _formHelp.BringToFront();
        }

        private void ShowUrlLoader(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_formLoadURL == null || _formLoadURL.IsDisposed)
            {
                _formLoadURL = new FormLoadURL();
            }
            _formLoadURL.Show();
            _formLoadURL.BringToFront();
        }

        // Export report to disk or a network resource
        private void SaveMenu(object sender, EventArgs e)
        {
            bool continueExport = false;

            if (NetDiags.TraceRouteResult.Count == 0 || PCInfo.TraceRouteData == null || PCInfo.TraceRouteData.Count == 0)
            {
                if (MessageBox.Show("There is no trace route data To export. Continue?", "Missing Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    continueExport = true;
                }
                else
                {
                    continueExport = false;
                }
            }
            else
            {
                continueExport = true;
            }

            if (continueExport)
            {
                menuExport.Show(btnExport, 0, btnExport.Top + btnExport.Height - 12);
            }
        }

        private void SaveRemote(object sender, EventArgs e)
        {
            string path = Microsoft.VisualBasic.Interaction.InputBox("Enter the network path where the report will be saved.", "Save To...").Trim();

            if (!string.IsNullOrWhiteSpace(path))
            {
                if (!path.StartsWith(@"\\"))
                {
                    path = @"\\" + path;
                }

                string result = SaveTo(path);
                if (result != null)
                {
                    MessageBox.Show("Report was saved On the remote location As " + result + ".", "Save Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RunGroupPolicy();
                }
            }
        }

        private void SaveDisk(object sender, EventArgs e)
        {
            string result = SaveTo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            if (result != null)
            {
                MessageBox.Show("Report was saved On your desktop As " + result + ".", "Save Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RunGroupPolicy();
            }
        }

        private string SaveTo(string path)
        {
            string mac = (PCInfo.MACAddress != null && PCInfo.MACAddress.Length >= 8) ? PCInfo.MACAddress.Substring(8) : PCInfo.MACAddress ?? "";
            string filename = "SnapLog-" + DateTime.Now.ToString("yyyyMMdd") + "-" + mac + ".txt";
            string target;

            if (path.Trim().EndsWith(@"\"))
            {
                target = path + filename;
            }
            else
            {
                target = path + @"\" + filename;
            }

            try
            {
                if (File.Exists(target))
                {
                    File.Delete(target);
                }

                using (StreamWriter outputFile = new StreamWriter(target))
                {
                    outputFile.WriteLine(PCInfo.GetReport());
                }

                if (File.Exists(target))
                {
                    return filename;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                MessageBox.Show("Error saving the report. Make sure that the path exists And that you have permission To access it.", "Save Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
