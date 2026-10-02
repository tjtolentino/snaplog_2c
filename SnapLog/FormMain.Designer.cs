namespace SnapLog
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSystem = new System.Windows.Forms.TabPage();
            this.chkPAC = new System.Windows.Forms.CheckBox();
            this.chkProxy = new System.Windows.Forms.CheckBox();
            this.lblDNS = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.LinkLabel6 = new System.Windows.Forms.LinkLabel();
            this.LinkLabel5 = new System.Windows.Forms.LinkLabel();
            this.LinkLabel4 = new System.Windows.Forms.LinkLabel();
            this.ChartUtilization = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LinkLabel2 = new System.Windows.Forms.LinkLabel();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblInternalIP1 = new System.Windows.Forms.Label();
            this.lblLogonServer = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblGatewayAddress = new System.Windows.Forms.Label();
            this.lblSubnetMask = new System.Windows.Forms.Label();
            this.lblWindowsArchitecture = new System.Windows.Forms.Label();
            this.lblWindowsVersion = new System.Windows.Forms.Label();
            this.lblComputerName = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabSoftware = new System.Windows.Forms.TabPage();
            this.progressGetApps = new System.Windows.Forms.ProgressBar();
            this.LinkLabel3 = new System.Windows.Forms.LinkLabel();
            this.Label28 = new System.Windows.Forms.Label();
            this.listSoftware = new System.Windows.Forms.ListBox();
            this.tabNetwork = new System.Windows.Forms.TabPage();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.LoadURL = new System.Windows.Forms.LinkLabel();
            this.chkTelNetStatus = new System.Windows.Forms.CheckBox();
            this.chkTraceRoute = new System.Windows.Forms.CheckBox();
            this.lblInternalIP2 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.lblTraceRoute = new System.Windows.Forms.LinkLabel();
            this.lblRemoteIP = new System.Windows.Forms.Label();
            this.lblExternalIP = new System.Windows.Forms.Label();
            this.Label99 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblMinRScore = new System.Windows.Forms.Label();
            this.lblCurrentRScore = new System.Windows.Forms.Label();
            this.lblPeakRScore = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.lblMinMOS = new System.Windows.Forms.Label();
            this.lblCurrentMOS = new System.Windows.Forms.Label();
            this.lblPeakMOS = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtEffectiveLatency = new System.Windows.Forms.TextBox();
            this.txtAverageLatency = new System.Windows.Forms.TextBox();
            this.txtJitter = new System.Windows.Forms.TextBox();
            this.txtLoss = new System.Windows.Forms.TextBox();
            this.txtBytesReceived = new System.Windows.Forms.TextBox();
            this.txtBytesSent = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPing = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboTarget = new System.Windows.Forms.ComboBox();
            this.btnIPRefresh = new System.Windows.Forms.Button();
            this.chartNetwork = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabVDI = new System.Windows.Forms.TabPage();
            this.listVDIRegistry = new System.Windows.Forms.ListView();
            this.colKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabScripts = new System.Windows.Forms.TabPage();
            this.Button1 = new System.Windows.Forms.Button();
            this.listScripts = new System.Windows.Forms.ListBox();
            this.timerNetUtilization = new System.Windows.Forms.Timer(this.components);
            this.bgMOSWorker = new System.ComponentModel.BackgroundWorker();
            this.bgRunTrace = new System.ComponentModel.BackgroundWorker();
            this.btnExport = new System.Windows.Forms.Button();
            this.timerPCUtilization = new System.Windows.Forms.Timer(this.components);
            this.bgInstalledSoftware = new System.ComponentModel.BackgroundWorker();
            this.menuExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToDiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToRemoteLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.bgTelnet = new System.ComponentModel.BackgroundWorker();
            this.btnSettings = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartUtilization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.tabSoftware.SuspendLayout();
            this.tabNetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNetwork)).BeginInit();
            this.tabVDI.SuspendLayout();
            this.tabScripts.SuspendLayout();
            this.menuExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSystem);
            this.tabMain.Controls.Add(this.tabSoftware);
            this.tabMain.Controls.Add(this.tabNetwork);
            this.tabMain.Controls.Add(this.tabVDI);
            this.tabMain.Controls.Add(this.tabScripts);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabMain.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(0, 36);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1024, 609);
            this.tabMain.TabIndex = 0;
            this.tabMain.Click += new System.EventHandler(this.TabClick);
            // 
            // tabSystem
            // 
            this.tabSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabSystem.Controls.Add(this.chkPAC);
            this.tabSystem.Controls.Add(this.chkProxy);
            this.tabSystem.Controls.Add(this.lblDNS);
            this.tabSystem.Controls.Add(this.Label29);
            this.tabSystem.Controls.Add(this.LinkLabel6);
            this.tabSystem.Controls.Add(this.LinkLabel5);
            this.tabSystem.Controls.Add(this.LinkLabel4);
            this.tabSystem.Controls.Add(this.ChartUtilization);
            this.tabSystem.Controls.Add(this.LinkLabel2);
            this.tabSystem.Controls.Add(this.LinkLabel1);
            this.tabSystem.Controls.Add(this.lblInternalIP1);
            this.tabSystem.Controls.Add(this.lblLogonServer);
            this.tabSystem.Controls.Add(this.lblDomain);
            this.tabSystem.Controls.Add(this.lblUsername);
            this.tabSystem.Controls.Add(this.lblGatewayAddress);
            this.tabSystem.Controls.Add(this.lblSubnetMask);
            this.tabSystem.Controls.Add(this.lblWindowsArchitecture);
            this.tabSystem.Controls.Add(this.lblWindowsVersion);
            this.tabSystem.Controls.Add(this.lblComputerName);
            this.tabSystem.Controls.Add(this.Label27);
            this.tabSystem.Controls.Add(this.Label24);
            this.tabSystem.Controls.Add(this.Label25);
            this.tabSystem.Controls.Add(this.Label26);
            this.tabSystem.Controls.Add(this.Label17);
            this.tabSystem.Controls.Add(this.Label18);
            this.tabSystem.Controls.Add(this.Label16);
            this.tabSystem.Controls.Add(this.Label15);
            this.tabSystem.Controls.Add(this.Label13);
            this.tabSystem.Controls.Add(this.PictureBox4);
            this.tabSystem.Controls.Add(this.PictureBox3);
            this.tabSystem.Controls.Add(this.PictureBox2);
            this.tabSystem.Location = new System.Drawing.Point(4, 33);
            this.tabSystem.Margin = new System.Windows.Forms.Padding(4);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Size = new System.Drawing.Size(1016, 572);
            this.tabSystem.TabIndex = 2;
            this.tabSystem.Text = "System";
            this.tabSystem.UseVisualStyleBackColor = true;
            // 
            // chkPAC
            // 
            this.chkPAC.AutoCheck = false;
            this.chkPAC.AutoSize = true;
            this.chkPAC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPAC.Location = new System.Drawing.Point(803, 193);
            this.chkPAC.Margin = new System.Windows.Forms.Padding(4);
            this.chkPAC.Name = "chkPAC";
            this.chkPAC.Size = new System.Drawing.Size(146, 25);
            this.chkPAC.TabIndex = 36;
            this.chkPAC.Text = "PAC File Enabled";
            this.chkPAC.UseVisualStyleBackColor = true;
            // 
            // chkProxy
            // 
            this.chkProxy.AutoCheck = false;
            this.chkProxy.AutoSize = true;
            this.chkProxy.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProxy.Location = new System.Drawing.Point(803, 159);
            this.chkProxy.Margin = new System.Windows.Forms.Padding(4);
            this.chkProxy.Name = "chkProxy";
            this.chkProxy.Size = new System.Drawing.Size(130, 25);
            this.chkProxy.TabIndex = 35;
            this.chkProxy.Text = "Proxy Enabled";
            this.chkProxy.UseVisualStyleBackColor = true;
            // 
            // lblDNS
            // 
            this.lblDNS.AutoSize = true;
            this.lblDNS.Location = new System.Drawing.Point(520, 252);
            this.lblDNS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNS.Name = "lblDNS";
            this.lblDNS.Size = new System.Drawing.Size(116, 24);
            this.lblDNS.TabIndex = 30;
            this.lblDNS.Text = "DNS Address";
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label29.Location = new System.Drawing.Point(395, 256);
            this.Label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(99, 21);
            this.Label29.TabIndex = 29;
            this.Label29.Text = "DNS Address";
            // 
            // LinkLabel6
            // 
            this.LinkLabel6.AutoSize = true;
            this.LinkLabel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLabel6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel6.Location = new System.Drawing.Point(49, 215);
            this.LinkLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLabel6.Name = "LinkLabel6";
            this.LinkLabel6.Size = new System.Drawing.Size(124, 21);
            this.LinkLabel6.TabIndex = 28;
            this.LinkLabel6.TabStop = true;
            this.LinkLabel6.Text = "Internet Options";
            this.LinkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LinkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkInternetOptions);
            // 
            // LinkLabel5
            // 
            this.LinkLabel5.AutoSize = true;
            this.LinkLabel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel5.Location = new System.Drawing.Point(64, 306);
            this.LinkLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLabel5.Name = "LinkLabel5";
            this.LinkLabel5.Size = new System.Drawing.Size(110, 21);
            this.LinkLabel5.TabIndex = 27;
            this.LinkLabel5.TabStop = true;
            this.LinkLabel5.Text = "User Accounts";
            this.LinkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LinkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkUserAccounts);
            // 
            // LinkLabel4
            // 
            this.LinkLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel4.Location = new System.Drawing.Point(43, 159);
            this.LinkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLabel4.Name = "LinkLabel4";
            this.LinkLabel4.Size = new System.Drawing.Size(135, 53);
            this.LinkLabel4.TabIndex = 26;
            this.LinkLabel4.TabStop = true;
            this.LinkLabel4.Text = "Network and Sharing Center";
            this.LinkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LinkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkNetworkSharingCenter);
            // 
            // ChartUtilization
            // 
            this.ChartUtilization.BackColor = System.Drawing.Color.Transparent;
            this.ChartUtilization.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.ScrollBar.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.ScrollBar.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.Gainsboro;
            chartArea1.CursorX.LineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.ChartUtilization.ChartAreas.Add(chartArea1);
            this.ChartUtilization.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.ChartUtilization.Legends.Add(legend1);
            this.ChartUtilization.Location = new System.Drawing.Point(0, 437);
            this.ChartUtilization.Margin = new System.Windows.Forms.Padding(4);
            this.ChartUtilization.Name = "ChartUtilization";
            this.ChartUtilization.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ChartUtilization.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "CPU";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Memory";
            this.ChartUtilization.Series.Add(series1);
            this.ChartUtilization.Series.Add(series2);
            this.ChartUtilization.Size = new System.Drawing.Size(1016, 135);
            this.ChartUtilization.TabIndex = 25;
            // 
            // LinkLabel2
            // 
            this.LinkLabel2.AutoSize = true;
            this.LinkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel2.Location = new System.Drawing.Point(43, 66);
            this.LinkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLabel2.Name = "LinkLabel2";
            this.LinkLabel2.Size = new System.Drawing.Size(130, 21);
            this.LinkLabel2.TabIndex = 24;
            this.LinkLabel2.TabStop = true;
            this.LinkLabel2.Text = "Windows Update";
            this.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkWindowsUpdate);
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel1.Location = new System.Drawing.Point(51, 34);
            this.LinkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(121, 21);
            this.LinkLabel1.TabIndex = 23;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Device Manager";
            this.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkDeviceManager);
            // 
            // lblInternalIP1
            // 
            this.lblInternalIP1.AutoSize = true;
            this.lblInternalIP1.Location = new System.Drawing.Point(520, 160);
            this.lblInternalIP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInternalIP1.Name = "lblInternalIP1";
            this.lblInternalIP1.Size = new System.Drawing.Size(168, 24);
            this.lblInternalIP1.TabIndex = 22;
            this.lblInternalIP1.Text = "Internal IP Address";
            // 
            // lblLogonServer
            // 
            this.lblLogonServer.AutoSize = true;
            this.lblLogonServer.Location = new System.Drawing.Point(521, 384);
            this.lblLogonServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogonServer.Name = "lblLogonServer";
            this.lblLogonServer.Size = new System.Drawing.Size(117, 24);
            this.lblLogonServer.TabIndex = 21;
            this.lblLogonServer.Text = "Logon Server";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(521, 351);
            this.lblDomain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(75, 24);
            this.lblDomain.TabIndex = 20;
            this.lblDomain.Text = "Domain";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(521, 315);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 24);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "User Name";
            // 
            // lblGatewayAddress
            // 
            this.lblGatewayAddress.AutoSize = true;
            this.lblGatewayAddress.Location = new System.Drawing.Point(520, 220);
            this.lblGatewayAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGatewayAddress.Name = "lblGatewayAddress";
            this.lblGatewayAddress.Size = new System.Drawing.Size(155, 24);
            this.lblGatewayAddress.TabIndex = 18;
            this.lblGatewayAddress.Text = "Gateway Address";
            // 
            // lblSubnetMask
            // 
            this.lblSubnetMask.AutoSize = true;
            this.lblSubnetMask.Location = new System.Drawing.Point(520, 191);
            this.lblSubnetMask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubnetMask.Name = "lblSubnetMask";
            this.lblSubnetMask.Size = new System.Drawing.Size(118, 24);
            this.lblSubnetMask.TabIndex = 17;
            this.lblSubnetMask.Text = "Subnet Mask";
            // 
            // lblWindowsArchitecture
            // 
            this.lblWindowsArchitecture.AutoSize = true;
            this.lblWindowsArchitecture.Location = new System.Drawing.Point(521, 105);
            this.lblWindowsArchitecture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWindowsArchitecture.Name = "lblWindowsArchitecture";
            this.lblWindowsArchitecture.Size = new System.Drawing.Size(196, 24);
            this.lblWindowsArchitecture.TabIndex = 15;
            this.lblWindowsArchitecture.Text = "Windows Architecture";
            // 
            // lblWindowsVersion
            // 
            this.lblWindowsVersion.AutoSize = true;
            this.lblWindowsVersion.Location = new System.Drawing.Point(521, 70);
            this.lblWindowsVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWindowsVersion.Name = "lblWindowsVersion";
            this.lblWindowsVersion.Size = new System.Drawing.Size(155, 24);
            this.lblWindowsVersion.TabIndex = 14;
            this.lblWindowsVersion.Text = "Windows Version";
            // 
            // lblComputerName
            // 
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Location = new System.Drawing.Point(521, 37);
            this.lblComputerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(148, 24);
            this.lblComputerName.TabIndex = 13;
            this.lblComputerName.Text = "Computer Name";
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label27.Location = new System.Drawing.Point(411, 164);
            this.Label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(83, 21);
            this.Label27.TabIndex = 12;
            this.Label27.Text = "IP Address";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.Location = new System.Drawing.Point(396, 384);
            this.Label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(100, 21);
            this.Label24.TabIndex = 11;
            this.Label24.Text = "Logon Server";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label25.Location = new System.Drawing.Point(431, 351);
            this.Label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(64, 21);
            this.Label25.TabIndex = 10;
            this.Label25.Text = "Domain";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label26.Location = new System.Drawing.Point(409, 318);
            this.Label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(87, 21);
            this.Label26.TabIndex = 9;
            this.Label26.Text = "User Name";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(363, 224);
            this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(131, 21);
            this.Label17.TabIndex = 8;
            this.Label17.Text = "Gateway Address";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.Location = new System.Drawing.Point(395, 194);
            this.Label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(101, 21);
            this.Label18.TabIndex = 7;
            this.Label18.Text = "Subnet Mask";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(325, 107);
            this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(165, 21);
            this.Label16.TabIndex = 5;
            this.Label16.Text = "Windows Architecture";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(360, 74);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(131, 21);
            this.Label15.TabIndex = 4;
            this.Label15.Text = "Windows Version";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(372, 39);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(125, 21);
            this.Label13.TabIndex = 3;
            this.Label13.Text = "Computer Name";
            // 
            // PictureBox4
            // 
            this.PictureBox4.Image = global::SnapLog.Properties.Resources.black_user;
            this.PictureBox4.Location = new System.Drawing.Point(188, 308);
            this.PictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(113, 100);
            this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox4.TabIndex = 2;
            this.PictureBox4.TabStop = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = global::SnapLog.Properties.Resources.black_cloud;
            this.PictureBox3.Location = new System.Drawing.Point(188, 169);
            this.PictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(113, 100);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 1;
            this.PictureBox3.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::SnapLog.Properties.Resources.black_computer;
            this.PictureBox2.Location = new System.Drawing.Point(188, 33);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(113, 100);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 0;
            this.PictureBox2.TabStop = false;
            // 
            // tabSoftware
            // 
            this.tabSoftware.Controls.Add(this.progressGetApps);
            this.tabSoftware.Controls.Add(this.LinkLabel3);
            this.tabSoftware.Controls.Add(this.Label28);
            this.tabSoftware.Controls.Add(this.listSoftware);
            this.tabSoftware.Location = new System.Drawing.Point(4, 33);
            this.tabSoftware.Margin = new System.Windows.Forms.Padding(4);
            this.tabSoftware.Name = "tabSoftware";
            this.tabSoftware.Size = new System.Drawing.Size(1012, 572);
            this.tabSoftware.TabIndex = 3;
            this.tabSoftware.Text = "Software";
            this.tabSoftware.UseVisualStyleBackColor = true;
            // 
            // progressGetApps
            // 
            this.progressGetApps.Location = new System.Drawing.Point(312, 268);
            this.progressGetApps.Margin = new System.Windows.Forms.Padding(4);
            this.progressGetApps.MarqueeAnimationSpeed = 30;
            this.progressGetApps.Name = "progressGetApps";
            this.progressGetApps.Size = new System.Drawing.Size(383, 28);
            this.progressGetApps.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressGetApps.TabIndex = 3;
            this.progressGetApps.Visible = false;
            // 
            // LinkLabel3
            // 
            this.LinkLabel3.AutoSize = true;
            this.LinkLabel3.Location = new System.Drawing.Point(773, 22);
            this.LinkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLabel3.Name = "LinkLabel3";
            this.LinkLabel3.Size = new System.Drawing.Size(202, 24);
            this.LinkLabel3.TabIndex = 2;
            this.LinkLabel3.TabStop = true;
            this.LinkLabel3.Text = "Add/Remove Programs";
            this.LinkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkProgramsAndFeatures);
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(23, 22);
            this.Label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(214, 24);
            this.Label28.TabIndex = 1;
            this.Label28.Text = "List of installed software";
            // 
            // listSoftware
            // 
            this.listSoftware.FormattingEnabled = true;
            this.listSoftware.ItemHeight = 24;
            this.listSoftware.Items.AddRange(new object[] {
            "Loading list of software. Please wait..."});
            this.listSoftware.Location = new System.Drawing.Point(11, 64);
            this.listSoftware.Margin = new System.Windows.Forms.Padding(4);
            this.listSoftware.Name = "listSoftware";
            this.listSoftware.Size = new System.Drawing.Size(991, 436);
            this.listSoftware.Sorted = true;
            this.listSoftware.TabIndex = 0;
            // 
            // tabNetwork
            // 
            this.tabNetwork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabNetwork.Controls.Add(this.Label19);
            this.tabNetwork.Controls.Add(this.Label20);
            this.tabNetwork.Controls.Add(this.Label21);
            this.tabNetwork.Controls.Add(this.LoadURL);
            this.tabNetwork.Controls.Add(this.chkTelNetStatus);
            this.tabNetwork.Controls.Add(this.chkTraceRoute);
            this.tabNetwork.Controls.Add(this.lblInternalIP2);
            this.tabNetwork.Controls.Add(this.Label14);
            this.tabNetwork.Controls.Add(this.lblTraceRoute);
            this.tabNetwork.Controls.Add(this.lblRemoteIP);
            this.tabNetwork.Controls.Add(this.lblExternalIP);
            this.tabNetwork.Controls.Add(this.Label99);
            this.tabNetwork.Controls.Add(this.Label2);
            this.tabNetwork.Controls.Add(this.lblMinRScore);
            this.tabNetwork.Controls.Add(this.lblCurrentRScore);
            this.tabNetwork.Controls.Add(this.lblPeakRScore);
            this.tabNetwork.Controls.Add(this.Label22);
            this.tabNetwork.Controls.Add(this.lblMinMOS);
            this.tabNetwork.Controls.Add(this.lblCurrentMOS);
            this.tabNetwork.Controls.Add(this.lblPeakMOS);
            this.tabNetwork.Controls.Add(this.Label12);
            this.tabNetwork.Controls.Add(this.Label11);
            this.tabNetwork.Controls.Add(this.Label10);
            this.tabNetwork.Controls.Add(this.Label9);
            this.tabNetwork.Controls.Add(this.txtEffectiveLatency);
            this.tabNetwork.Controls.Add(this.txtAverageLatency);
            this.tabNetwork.Controls.Add(this.txtJitter);
            this.tabNetwork.Controls.Add(this.txtLoss);
            this.tabNetwork.Controls.Add(this.txtBytesReceived);
            this.tabNetwork.Controls.Add(this.txtBytesSent);
            this.tabNetwork.Controls.Add(this.Label8);
            this.tabNetwork.Controls.Add(this.Label7);
            this.tabNetwork.Controls.Add(this.Label6);
            this.tabNetwork.Controls.Add(this.Label5);
            this.tabNetwork.Controls.Add(this.Label4);
            this.tabNetwork.Controls.Add(this.Label3);
            this.tabNetwork.Controls.Add(this.btnStart);
            this.tabNetwork.Controls.Add(this.lblPing);
            this.tabNetwork.Controls.Add(this.Label1);
            this.tabNetwork.Controls.Add(this.cboTarget);
            this.tabNetwork.Controls.Add(this.btnIPRefresh);
            this.tabNetwork.Controls.Add(this.chartNetwork);
            this.tabNetwork.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNetwork.Location = new System.Drawing.Point(4, 33);
            this.tabNetwork.Margin = new System.Windows.Forms.Padding(4);
            this.tabNetwork.Name = "tabNetwork";
            this.tabNetwork.Padding = new System.Windows.Forms.Padding(4);
            this.tabNetwork.Size = new System.Drawing.Size(1016, 572);
            this.tabNetwork.TabIndex = 0;
            this.tabNetwork.Text = "Network";
            this.tabNetwork.UseVisualStyleBackColor = true;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(705, 324);
            this.Label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(64, 17);
            this.Label19.TabIndex = 51;
            this.Label19.Text = "CURRENT";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(736, 354);
            this.Label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(32, 17);
            this.Label20.TabIndex = 50;
            this.Label20.Text = "LOW";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.Location = new System.Drawing.Point(728, 287);
            this.Label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(40, 17);
            this.Label21.TabIndex = 49;
            this.Label21.Text = " HIGH";
            // 
            // LoadURL
            // 
            this.LoadURL.AutoSize = true;
            this.LoadURL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadURL.Location = new System.Drawing.Point(479, 76);
            this.LoadURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoadURL.Name = "LoadURL";
            this.LoadURL.Size = new System.Drawing.Size(105, 18);
            this.LoadURL.TabIndex = 47;
            this.LoadURL.TabStop = true;
            this.LoadURL.Text = "Load from file...";
            this.LoadURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowUrlLoader);
            // 
            // chkTelNetStatus
            // 
            this.chkTelNetStatus.AutoCheck = false;
            this.chkTelNetStatus.AutoSize = true;
            this.chkTelNetStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTelNetStatus.Location = new System.Drawing.Point(768, 160);
            this.chkTelNetStatus.Margin = new System.Windows.Forms.Padding(4);
            this.chkTelNetStatus.Name = "chkTelNetStatus";
            this.chkTelNetStatus.Size = new System.Drawing.Size(121, 25);
            this.chkTelNetStatus.TabIndex = 46;
            this.chkTelNetStatus.Text = "Telnet Status";
            this.chkTelNetStatus.UseVisualStyleBackColor = true;
            // 
            // chkTraceRoute
            // 
            this.chkTraceRoute.AutoCheck = false;
            this.chkTraceRoute.AutoSize = true;
            this.chkTraceRoute.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTraceRoute.Location = new System.Drawing.Point(768, 119);
            this.chkTraceRoute.Margin = new System.Windows.Forms.Padding(4);
            this.chkTraceRoute.Name = "chkTraceRoute";
            this.chkTraceRoute.Size = new System.Drawing.Size(18, 17);
            this.chkTraceRoute.TabIndex = 45;
            this.chkTraceRoute.UseVisualStyleBackColor = true;
            // 
            // lblInternalIP2
            // 
            this.lblInternalIP2.AutoSize = true;
            this.lblInternalIP2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternalIP2.Location = new System.Drawing.Point(600, 117);
            this.lblInternalIP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInternalIP2.Name = "lblInternalIP2";
            this.lblInternalIP2.Size = new System.Drawing.Size(65, 24);
            this.lblInternalIP2.TabIndex = 44;
            this.lblInternalIP2.Text = "0.0.0.0";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(507, 116);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(77, 24);
            this.Label14.TabIndex = 43;
            this.Label14.Text = "Local IP:";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTraceRoute
            // 
            this.lblTraceRoute.AutoSize = true;
            this.lblTraceRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTraceRoute.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraceRoute.Location = new System.Drawing.Point(792, 118);
            this.lblTraceRoute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTraceRoute.Name = "lblTraceRoute";
            this.lblTraceRoute.Size = new System.Drawing.Size(139, 21);
            this.lblTraceRoute.TabIndex = 42;
            this.lblTraceRoute.TabStop = true;
            this.lblTraceRoute.Text = "Trace Route Status";
            this.lblTraceRoute.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkTraceRoute);
            // 
            // lblRemoteIP
            // 
            this.lblRemoteIP.AutoSize = true;
            this.lblRemoteIP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoteIP.Location = new System.Drawing.Point(600, 201);
            this.lblRemoteIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemoteIP.Name = "lblRemoteIP";
            this.lblRemoteIP.Size = new System.Drawing.Size(65, 24);
            this.lblRemoteIP.TabIndex = 41;
            this.lblRemoteIP.Text = "0.0.0.0";
            // 
            // lblExternalIP
            // 
            this.lblExternalIP.AutoSize = true;
            this.lblExternalIP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExternalIP.Location = new System.Drawing.Point(600, 159);
            this.lblExternalIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExternalIP.Name = "lblExternalIP";
            this.lblExternalIP.Size = new System.Drawing.Size(65, 24);
            this.lblExternalIP.TabIndex = 40;
            this.lblExternalIP.Text = "0.0.0.0";
            // 
            // Label99
            // 
            this.Label99.AutoSize = true;
            this.Label99.Location = new System.Drawing.Point(485, 201);
            this.Label99.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label99.Name = "Label99";
            this.Label99.Size = new System.Drawing.Size(100, 24);
            this.Label99.TabIndex = 39;
            this.Label99.Text = "Remote IP:";
            this.Label99.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(483, 159);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(104, 24);
            this.Label2.TabIndex = 38;
            this.Label2.Text = "External IP:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMinRScore
            // 
            this.lblMinRScore.AutoSize = true;
            this.lblMinRScore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinRScore.ForeColor = System.Drawing.Color.Red;
            this.lblMinRScore.Location = new System.Drawing.Point(767, 351);
            this.lblMinRScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinRScore.Name = "lblMinRScore";
            this.lblMinRScore.Size = new System.Drawing.Size(105, 24);
            this.lblMinRScore.TabIndex = 36;
            this.lblMinRScore.Text = "0.00000000";
            // 
            // lblCurrentRScore
            // 
            this.lblCurrentRScore.AutoSize = true;
            this.lblCurrentRScore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRScore.Location = new System.Drawing.Point(767, 319);
            this.lblCurrentRScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentRScore.Name = "lblCurrentRScore";
            this.lblCurrentRScore.Size = new System.Drawing.Size(105, 24);
            this.lblCurrentRScore.TabIndex = 35;
            this.lblCurrentRScore.Text = "0.00000000";
            // 
            // lblPeakRScore
            // 
            this.lblPeakRScore.AutoSize = true;
            this.lblPeakRScore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeakRScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPeakRScore.Location = new System.Drawing.Point(767, 283);
            this.lblPeakRScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeakRScore.Name = "lblPeakRScore";
            this.lblPeakRScore.Size = new System.Drawing.Size(105, 24);
            this.lblPeakRScore.TabIndex = 34;
            this.lblPeakRScore.Text = "0.00000000";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.Location = new System.Drawing.Point(696, 249);
            this.Label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(72, 24);
            this.Label22.TabIndex = 30;
            this.Label22.Text = "R-Score";
            // 
            // lblMinMOS
            // 
            this.lblMinMOS.AutoSize = true;
            this.lblMinMOS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinMOS.ForeColor = System.Drawing.Color.Red;
            this.lblMinMOS.Location = new System.Drawing.Point(555, 351);
            this.lblMinMOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinMOS.Name = "lblMinMOS";
            this.lblMinMOS.Size = new System.Drawing.Size(105, 24);
            this.lblMinMOS.TabIndex = 29;
            this.lblMinMOS.Text = "0.00000000";
            // 
            // lblCurrentMOS
            // 
            this.lblCurrentMOS.AutoSize = true;
            this.lblCurrentMOS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentMOS.Location = new System.Drawing.Point(555, 319);
            this.lblCurrentMOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentMOS.Name = "lblCurrentMOS";
            this.lblCurrentMOS.Size = new System.Drawing.Size(105, 24);
            this.lblCurrentMOS.TabIndex = 28;
            this.lblCurrentMOS.Text = "0.00000000";
            // 
            // lblPeakMOS
            // 
            this.lblPeakMOS.AutoSize = true;
            this.lblPeakMOS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeakMOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPeakMOS.Location = new System.Drawing.Point(555, 283);
            this.lblPeakMOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeakMOS.Name = "lblPeakMOS";
            this.lblPeakMOS.Size = new System.Drawing.Size(105, 24);
            this.lblPeakMOS.TabIndex = 27;
            this.lblPeakMOS.Text = "0.00000000";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(491, 324);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(64, 17);
            this.Label12.TabIndex = 22;
            this.Label12.Text = "CURRENT";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(523, 356);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(32, 17);
            this.Label11.TabIndex = 21;
            this.Label11.Text = "LOW";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(515, 288);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(40, 17);
            this.Label10.TabIndex = 20;
            this.Label10.Text = " HIGH";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(485, 249);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(99, 24);
            this.Label9.TabIndex = 19;
            this.Label9.Text = "MOS Score";
            // 
            // txtEffectiveLatency
            // 
            this.txtEffectiveLatency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEffectiveLatency.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEffectiveLatency.Location = new System.Drawing.Point(237, 330);
            this.txtEffectiveLatency.Margin = new System.Windows.Forms.Padding(4);
            this.txtEffectiveLatency.Name = "txtEffectiveLatency";
            this.txtEffectiveLatency.ReadOnly = true;
            this.txtEffectiveLatency.Size = new System.Drawing.Size(143, 32);
            this.txtEffectiveLatency.TabIndex = 18;
            this.txtEffectiveLatency.Text = "0";
            this.txtEffectiveLatency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAverageLatency
            // 
            this.txtAverageLatency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAverageLatency.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverageLatency.Location = new System.Drawing.Point(237, 287);
            this.txtAverageLatency.Margin = new System.Windows.Forms.Padding(4);
            this.txtAverageLatency.Name = "txtAverageLatency";
            this.txtAverageLatency.ReadOnly = true;
            this.txtAverageLatency.Size = new System.Drawing.Size(143, 32);
            this.txtAverageLatency.TabIndex = 17;
            this.txtAverageLatency.Text = "0";
            this.txtAverageLatency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJitter
            // 
            this.txtJitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJitter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJitter.Location = new System.Drawing.Point(237, 244);
            this.txtJitter.Margin = new System.Windows.Forms.Padding(4);
            this.txtJitter.Name = "txtJitter";
            this.txtJitter.ReadOnly = true;
            this.txtJitter.Size = new System.Drawing.Size(143, 32);
            this.txtJitter.TabIndex = 16;
            this.txtJitter.Text = "0";
            this.txtJitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLoss
            // 
            this.txtLoss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoss.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoss.Location = new System.Drawing.Point(237, 201);
            this.txtLoss.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoss.Name = "txtLoss";
            this.txtLoss.ReadOnly = true;
            this.txtLoss.Size = new System.Drawing.Size(143, 32);
            this.txtLoss.TabIndex = 15;
            this.txtLoss.Text = "0";
            this.txtLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBytesReceived
            // 
            this.txtBytesReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBytesReceived.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBytesReceived.Location = new System.Drawing.Point(237, 158);
            this.txtBytesReceived.Margin = new System.Windows.Forms.Padding(4);
            this.txtBytesReceived.Name = "txtBytesReceived";
            this.txtBytesReceived.ReadOnly = true;
            this.txtBytesReceived.Size = new System.Drawing.Size(183, 32);
            this.txtBytesReceived.TabIndex = 14;
            this.txtBytesReceived.Text = "0";
            this.txtBytesReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBytesSent
            // 
            this.txtBytesSent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBytesSent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBytesSent.Location = new System.Drawing.Point(237, 114);
            this.txtBytesSent.Margin = new System.Windows.Forms.Padding(4);
            this.txtBytesSent.Name = "txtBytesSent";
            this.txtBytesSent.ReadOnly = true;
            this.txtBytesSent.Size = new System.Drawing.Size(183, 32);
            this.txtBytesSent.TabIndex = 13;
            this.txtBytesSent.Text = "0";
            this.txtBytesSent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(61, 334);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(147, 24);
            this.Label8.TabIndex = 11;
            this.Label8.Text = "Effective Latency";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(63, 290);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(145, 24);
            this.Label7.TabIndex = 10;
            this.Label7.Text = "Average Latency";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(157, 246);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(51, 24);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "Jitter";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(105, 206);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(103, 24);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Packet Loss";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(75, 160);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(134, 24);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Bytes Received";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(111, 117);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(97, 24);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Bytes Sent";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(607, 39);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 34);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Go";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.NetworkGoButton);
            // 
            // lblPing
            // 
            this.lblPing.AutoSize = true;
            this.lblPing.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPing.Location = new System.Drawing.Point(31, 401);
            this.lblPing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPing.Name = "lblPing";
            this.lblPing.Size = new System.Drawing.Size(176, 18);
            this.lblPing.TabIndex = 4;
            this.lblPing.Text = "Ping response time...";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(80, 46);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(131, 24);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Remote Target";
            // 
            // cboTarget
            // 
            this.cboTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTarget.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTarget.FormattingEnabled = true;
            this.cboTarget.Location = new System.Drawing.Point(236, 39);
            this.cboTarget.Margin = new System.Windows.Forms.Padding(4);
            this.cboTarget.Name = "cboTarget";
            this.cboTarget.Size = new System.Drawing.Size(361, 32);
            this.cboTarget.TabIndex = 2;
            // 
            // btnIPRefresh
            // 
            this.btnIPRefresh.BackColor = System.Drawing.Color.Red;
            this.btnIPRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIPRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIPRefresh.ForeColor = System.Drawing.Color.White;
            this.btnIPRefresh.Location = new System.Drawing.Point(744, 39);
            this.btnIPRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnIPRefresh.Name = "btnIPRefresh";
            this.btnIPRefresh.Size = new System.Drawing.Size(236, 33);
            this.btnIPRefresh.TabIndex = 1;
            this.btnIPRefresh.Text = "IP Refresh";
            this.btnIPRefresh.UseVisualStyleBackColor = false;
            this.btnIPRefresh.Click += new System.EventHandler(this.RefreshConnection);
            // 
            // chartNetwork
            // 
            this.chartNetwork.BackColor = System.Drawing.Color.Transparent;
            this.chartNetwork.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.ScrollBar.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.ScrollBar.Enabled = false;
            chartArea2.BorderColor = System.Drawing.Color.Gainsboro;
            chartArea2.Name = "ChartArea1";
            this.chartNetwork.ChartAreas.Add(chartArea2);
            this.chartNetwork.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            this.chartNetwork.Legends.Add(legend2);
            this.chartNetwork.Location = new System.Drawing.Point(4, 423);
            this.chartNetwork.Margin = new System.Windows.Forms.Padding(4);
            this.chartNetwork.Name = "chartNetwork";
            this.chartNetwork.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartNetwork.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Ping Time";
            series3.YValuesPerPoint = 2;
            this.chartNetwork.Series.Add(series3);
            this.chartNetwork.Size = new System.Drawing.Size(1008, 145);
            this.chartNetwork.TabIndex = 0;
            this.chartNetwork.Text = "Chart1";
            // 
            // tabVDI
            // 
            this.tabVDI.BackgroundImage = global::SnapLog.Properties.Resources.cloud;
            this.tabVDI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabVDI.Controls.Add(this.listVDIRegistry);
            this.tabVDI.Location = new System.Drawing.Point(4, 33);
            this.tabVDI.Margin = new System.Windows.Forms.Padding(4);
            this.tabVDI.Name = "tabVDI";
            this.tabVDI.Padding = new System.Windows.Forms.Padding(4);
            this.tabVDI.Size = new System.Drawing.Size(1012, 572);
            this.tabVDI.TabIndex = 1;
            this.tabVDI.Text = "VDI";
            this.tabVDI.UseVisualStyleBackColor = true;
            // 
            // listVDIRegistry
            // 
            this.listVDIRegistry.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listVDIRegistry.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colKey,
            this.colVal});
            this.listVDIRegistry.FullRowSelect = true;
            this.listVDIRegistry.GridLines = true;
            this.listVDIRegistry.HotTracking = true;
            this.listVDIRegistry.HoverSelection = true;
            this.listVDIRegistry.Location = new System.Drawing.Point(11, 7);
            this.listVDIRegistry.Margin = new System.Windows.Forms.Padding(4);
            this.listVDIRegistry.Name = "listVDIRegistry";
            this.listVDIRegistry.Size = new System.Drawing.Size(991, 552);
            this.listVDIRegistry.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listVDIRegistry.TabIndex = 0;
            this.listVDIRegistry.UseCompatibleStateImageBehavior = false;
            this.listVDIRegistry.View = System.Windows.Forms.View.Details;
            // 
            // colKey
            // 
            this.colKey.Text = "Key";
            this.colKey.Width = 231;
            // 
            // colVal
            // 
            this.colVal.Text = "Value";
            this.colVal.Width = 253;
            // 
            // tabScripts
            // 
            this.tabScripts.Controls.Add(this.Button1);
            this.tabScripts.Controls.Add(this.listScripts);
            this.tabScripts.Location = new System.Drawing.Point(4, 33);
            this.tabScripts.Margin = new System.Windows.Forms.Padding(4);
            this.tabScripts.Name = "tabScripts";
            this.tabScripts.Size = new System.Drawing.Size(1012, 572);
            this.tabScripts.TabIndex = 4;
            this.tabScripts.Text = "Scripts";
            this.tabScripts.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(785, 524);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(217, 36);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Execute Script";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listScripts
            // 
            this.listScripts.Dock = System.Windows.Forms.DockStyle.Top;
            this.listScripts.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listScripts.FormattingEnabled = true;
            this.listScripts.ItemHeight = 32;
            this.listScripts.Location = new System.Drawing.Point(0, 0);
            this.listScripts.Margin = new System.Windows.Forms.Padding(4);
            this.listScripts.Name = "listScripts";
            this.listScripts.Size = new System.Drawing.Size(1012, 516);
            this.listScripts.Sorted = true;
            this.listScripts.TabIndex = 2;
            // 
            // timerNetUtilization
            // 
            this.timerNetUtilization.Interval = 1000;
            this.timerNetUtilization.Tick += new System.EventHandler(this.TimerNetworkUtilization);
            // 
            // bgMOSWorker
            // 
            this.bgMOSWorker.WorkerReportsProgress = true;
            this.bgMOSWorker.WorkerSupportsCancellation = true;
            this.bgMOSWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.NetworkDiagnostics_BUSY);
            this.bgMOSWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.NetworkDiagnostics_DONE);
            // 
            // bgRunTrace
            // 
            this.bgRunTrace.WorkerReportsProgress = true;
            this.bgRunTrace.WorkerSupportsCancellation = true;
            this.bgRunTrace.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RunTrace_BUSY);
            this.bgRunTrace.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.RunTrace_DONE);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(889, 15);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(60, 44);
            this.btnExport.TabIndex = 2;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.SaveMenu);
            // 
            // timerPCUtilization
            // 
            this.timerPCUtilization.Interval = 1000;
            this.timerPCUtilization.Tick += new System.EventHandler(this.TimerComputerUtilization);
            // 
            // bgInstalledSoftware
            // 
            this.bgInstalledSoftware.DoWork += new System.ComponentModel.DoWorkEventHandler(this.InstalledSoftware_BUSY);
            this.bgInstalledSoftware.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.InstalledSoftware_DONE);
            // 
            // menuExport
            // 
            this.menuExport.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuExport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToDiskToolStripMenuItem,
            this.ToRemoteLocationToolStripMenuItem});
            this.menuExport.Name = "menuExport";
            this.menuExport.Size = new System.Drawing.Size(219, 56);
            // 
            // ToDiskToolStripMenuItem
            // 
            this.ToDiskToolStripMenuItem.Name = "ToDiskToolStripMenuItem";
            this.ToDiskToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.ToDiskToolStripMenuItem.Text = "To Disk";
            this.ToDiskToolStripMenuItem.Click += new System.EventHandler(this.SaveDisk);
            // 
            // ToRemoteLocationToolStripMenuItem
            // 
            this.ToRemoteLocationToolStripMenuItem.Name = "ToRemoteLocationToolStripMenuItem";
            this.ToRemoteLocationToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.ToRemoteLocationToolStripMenuItem.Text = "To Remote Location";
            this.ToRemoteLocationToolStripMenuItem.Click += new System.EventHandler(this.SaveRemote);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = global::SnapLog.Properties.Resources.TeleTech;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox1.Location = new System.Drawing.Point(596, 12);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(211, 48);
            this.PictureBox1.TabIndex = 1;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.ShowAbout);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.Location = new System.Drawing.Point(955, 15);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(60, 44);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.ShowHelp);
            // 
            // bgTelnet
            // 
            this.bgTelnet.WorkerReportsProgress = true;
            this.bgTelnet.WorkerSupportsCancellation = true;
            this.bgTelnet.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RunTelnet_BUSY);
            this.bgTelnet.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.RunTelnet_DONE);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(821, 15);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(60, 44);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.ShowConfig);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1024, 645);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1042, 690);
            this.MinimumSize = new System.Drawing.Size(1042, 690);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnapLog 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_Exit);
            this.Load += new System.EventHandler(this.FormMain_Start);
            this.tabMain.ResumeLayout(false);
            this.tabSystem.ResumeLayout(false);
            this.tabSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartUtilization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.tabSoftware.ResumeLayout(false);
            this.tabSoftware.PerformLayout();
            this.tabNetwork.ResumeLayout(false);
            this.tabNetwork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNetwork)).EndInit();
            this.tabVDI.ResumeLayout(false);
            this.tabScripts.ResumeLayout(false);
            this.menuExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        internal System.Windows.Forms.TabControl tabMain;
        internal System.Windows.Forms.TabPage tabNetwork;
        internal System.Windows.Forms.TabPage tabVDI;
        internal System.Windows.Forms.DataVisualization.Charting.Chart chartNetwork;
        internal System.Windows.Forms.ComboBox cboTarget;
        internal System.Windows.Forms.Button btnIPRefresh;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblPing;
        internal System.Windows.Forms.Button btnStart;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtEffectiveLatency;
        internal System.Windows.Forms.TextBox txtAverageLatency;
        internal System.Windows.Forms.TextBox txtJitter;
        internal System.Windows.Forms.TextBox txtLoss;
        internal System.Windows.Forms.TextBox txtBytesReceived;
        internal System.Windows.Forms.TextBox txtBytesSent;
        internal System.Windows.Forms.Label lblMinRScore;
        internal System.Windows.Forms.Label lblCurrentRScore;
        internal System.Windows.Forms.Label lblPeakRScore;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label lblMinMOS;
        internal System.Windows.Forms.Label lblCurrentMOS;
        internal System.Windows.Forms.Label lblPeakMOS;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Timer timerNetUtilization;
        internal System.ComponentModel.BackgroundWorker bgMOSWorker;
        internal System.ComponentModel.BackgroundWorker bgRunTrace;
        internal System.Windows.Forms.Label lblRemoteIP;
        internal System.Windows.Forms.Label lblExternalIP;
        internal System.Windows.Forms.Label Label99;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.LinkLabel lblTraceRoute;
        internal System.Windows.Forms.ListView listVDIRegistry;
        internal System.Windows.Forms.ColumnHeader colKey;
        internal System.Windows.Forms.ColumnHeader colVal;
        internal System.Windows.Forms.Label lblInternalIP2;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.TabPage tabSystem;
        internal System.Windows.Forms.Button btnExport;
        internal System.Windows.Forms.TabPage tabSoftware;
        internal System.Windows.Forms.ListBox listSoftware;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.PictureBox PictureBox4;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label lblInternalIP1;
        internal System.Windows.Forms.Label lblLogonServer;
        internal System.Windows.Forms.Label lblDomain;
        internal System.Windows.Forms.Label lblUsername;
        internal System.Windows.Forms.Label lblGatewayAddress;
        internal System.Windows.Forms.Label lblSubnetMask;
        internal System.Windows.Forms.Label lblWindowsArchitecture;
        internal System.Windows.Forms.Label lblWindowsVersion;
        internal System.Windows.Forms.Label lblComputerName;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.LinkLabel LinkLabel2;
        internal System.Windows.Forms.LinkLabel LinkLabel1;
        internal System.Windows.Forms.DataVisualization.Charting.Chart ChartUtilization;
        internal System.Windows.Forms.Timer timerPCUtilization;
        internal System.Windows.Forms.LinkLabel LinkLabel3;
        internal System.Windows.Forms.LinkLabel LinkLabel5;
        internal System.Windows.Forms.LinkLabel LinkLabel4;
        internal System.Windows.Forms.LinkLabel LinkLabel6;
        internal System.Windows.Forms.Label lblDNS;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.CheckBox chkTelNetStatus;
        internal System.Windows.Forms.CheckBox chkTraceRoute;
        internal System.ComponentModel.BackgroundWorker bgInstalledSoftware;
        internal System.Windows.Forms.ProgressBar progressGetApps;
        internal System.Windows.Forms.ContextMenuStrip menuExport;
        internal System.Windows.Forms.ToolStripMenuItem ToDiskToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToRemoteLocationToolStripMenuItem;
        internal System.Windows.Forms.CheckBox chkPAC;
        internal System.Windows.Forms.CheckBox chkProxy;
        internal System.Windows.Forms.LinkLabel LoadURL;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Button btnHelp;
        internal System.ComponentModel.BackgroundWorker bgTelnet;
        internal System.Windows.Forms.Button btnSettings;
        internal System.Windows.Forms.TabPage tabScripts;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.ListBox listScripts;
    }
}
