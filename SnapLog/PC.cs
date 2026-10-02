using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace SnapLog
{
    public class PC
    {
        public string ComputerName { get; private set; } = "";
        public string WindowsVersion { get; private set; } = "";
        public string WindowsArchitecture { get; private set; } = "";

        public IPAddress InternalIPAddress { get; set; } = IPAddress.Parse("0.0.0.0");
        public IPAddress ExternalIPAddress { get; set; } = IPAddress.Parse("0.0.0.0");
        public IPAddress SubnetMask { get; set; } = IPAddress.Parse("0.0.0.0");
        public IPAddress GatewayAddress { get; set; } = IPAddress.Parse("0.0.0.0");
        public IPAddress DNSAddress { get; set; } = IPAddress.Parse("0.0.0.0");

        public NetworkDiagnostics.NetworkDiagnostics.NETWORKDIAGNOSTICTEST_REPLY NetworkStats { get; set; } = new NetworkDiagnostics.NetworkDiagnostics.NETWORKDIAGNOSTICTEST_REPLY();
        public string NetworkDeviceName { get; set; } = "";
        public List<NetworkInterface> NetworkDevices { get; set; }
        public string MACAddress { get; set; } = "";
        public bool TelnetStatus { get; set; } = false;
        public List<NetworkDiagnostics.NetworkDiagnostics.ICMP_REPLY> TraceRouteData { get; set; } = new List<NetworkDiagnostics.NetworkDiagnostics.ICMP_REPLY>();

        public string Username { get; private set; } = "";
        public string Domain { get; private set; } = "";
        public string LogonServer { get; private set; } = "";

        public int ProcUtilization { get; set; } = 0;
        public int MemUtilization { get; set; } = 0;
        public int TotalInstalledMemory { get; private set; } = 0;

        public List<string> InstalledApps { get; set; } = new List<string>();
        public List<string> VDIRegistry { get; set; } = new List<string>();

        public PC() // initialize
        {
            ComputerName = Environment.MachineName;

            var compInfo = new Microsoft.VisualBasic.Devices.ComputerInfo();
            WindowsVersion = compInfo.OSFullName + " (" + compInfo.OSVersion + ")";
            TotalInstalledMemory = (int)(compInfo.TotalPhysicalMemory / 1024 / 1024 / 1024);

            if (Environment.Is64BitOperatingSystem)
            {
                WindowsArchitecture = "64bit Operating System";
            }
            else
            {
                WindowsArchitecture = "32bit Operating System";
            }

            try
            {
                Username = WindowsIdentity.GetCurrent().Name;
            }
            catch
            {
                Username = Environment.UserName;
            }

            object partOfDomain = GetWMIComputerSystem("PartOfDomain");
            if (partOfDomain != null && Convert.ToBoolean(partOfDomain))
            {
                Domain = GetWMIComputerSystem("Domain")?.ToString() ?? "";
                LogonServer = Environment.GetEnvironmentVariable("LOGONSERVER") ?? "";
            }
            else
            {
                Domain = "WORKGROUP";
                LogonServer = "n/a";
            }

            InitializeNetworkInterface();
            RefreshIPInformation();
        }

        // WMI interface
        private object GetWMIComputerSystem(string attr)
        {
            try
            {
                using (ManagementClass c = new ManagementClass("Win32_ComputerSystem"))
                using (ManagementObjectCollection o = c.GetInstances())
                {
                    foreach (ManagementObject x in o)
                    {
                        return x[attr];
                    }
                }
            }
            catch
            {
            }
            return null;
        }

        public void ResetNetworkStats()
        {
            NetworkStats = new NetworkDiagnostics.NetworkDiagnostics.NETWORKDIAGNOSTICTEST_REPLY();
            TraceRouteData = new List<NetworkDiagnostics.NetworkDiagnostics.ICMP_REPLY>();
        }

        // checks if proxy has been set
        public bool HasProxyEnabled()
        {
            try
            {
                object r = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", null);

                if (r != null && !string.IsNullOrWhiteSpace(r.ToString()) && Convert.ToInt32(r) != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        // checks if PAC file has been set
        public bool HasInternetAutoConfig()
        {
            try
            {
                object r = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "AutoConfigURL", null);

                if (r != null && !string.IsNullOrWhiteSpace(r.ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        // identify network devices
        private void InitializeNetworkInterface() // display list of network devices connected
        {
            NetworkInterface[] netDev = NetworkInterface.GetAllNetworkInterfaces();

            NetworkDevices = new List<NetworkInterface>();
            foreach (var device in netDev)
            {
                if (device.OperationalStatus == OperationalStatus.Up &&
                    !device.Description.Contains("VM") &&
                    !device.Description.Contains("Virtual") &&
                    !device.Description.Contains("VPN") &&
                    !device.Description.Contains("Software") &&
                    !device.Description.Contains("AnyConnect") &&
                    !device.Description.Contains("Bluetooth") &&
                    !device.Description.Contains("Miniport") &&
                    !device.Description.Contains("Loopback"))
                {
                    NetworkDevices.Add(device);
                }
            }

            if (NetworkDevices.Count > 0)
            {
                NetworkDeviceName = NetworkDevices[0].Description;
                MACAddress = NetworkDevices[0].GetPhysicalAddress().ToString();
            }
        }

        // refresh all IP properties
        private void RefreshIPInformation()
        {
            InternalIPAddress = GetInternalIP() ?? IPAddress.Parse("0.0.0.0");
            ExternalIPAddress = GetExternalIP() ?? IPAddress.Parse("0.0.0.0");
            SubnetMask = GetSubnetMask() ?? IPAddress.Parse("0.0.0.0");
            GatewayAddress = GetGatewayIP() ?? IPAddress.Parse("0.0.0.0");
            DNSAddress = GetDNSIP() ?? IPAddress.Parse("0.0.0.0");
        }

        private IPAddress GetExternalIP()
        {
            try
            {
                string externalIP = (new WebClient()).DownloadString("http://checkip.dyndns.org/");
                externalIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")).Matches(externalIP)[0].ToString();
                return IPAddress.Parse(externalIP);
            }
            catch
            {
                return IPAddress.Parse("0.0.0.0");
            }
        }

        private IPAddress GetGatewayIP()
        {
            if (NetworkDevices == null || NetworkDevices.Count == 0) return IPAddress.Parse("0.0.0.0");
            IPInterfaceProperties adapterProperties = NetworkDevices[0].GetIPProperties();
            if (adapterProperties.GatewayAddresses.Count > 0)
            {
                return adapterProperties.GatewayAddresses[0].Address;
            }
            return IPAddress.Parse("0.0.0.0");
        }

        private IPAddress GetDNSIP()
        {
            if (NetworkDevices == null || NetworkDevices.Count == 0) return IPAddress.Parse("0.0.0.0");
            IPInterfaceProperties adapterProperties = NetworkDevices[0].GetIPProperties();
            if (adapterProperties.DnsAddresses.Count > 0)
            {
                return adapterProperties.DnsAddresses[0];
            }
            return IPAddress.Parse("0.0.0.0");
        }

        private IPAddress GetSubnetMask()
        {
            if (NetworkDevices == null || NetworkDevices.Count == 0) return null;
            UnicastIPAddressInformationCollection ipInfoCol = NetworkDevices[0].GetIPProperties().UnicastAddresses;

            foreach (UnicastIPAddressInformation ipInfo in ipInfoCol)
            {
                if (ipInfo.IPv4Mask != null && ipInfo.IPv4Mask.ToString() != "0.0.0.0")
                {
                    return ipInfo.IPv4Mask;
                }
            }

            return null;
        }

        private IPAddress GetInternalIP()
        {
            if (NetworkDevices == null || NetworkDevices.Count == 0) return null;
            UnicastIPAddressInformationCollection ipInfoCol = NetworkDevices[0].GetIPProperties().UnicastAddresses;

            foreach (UnicastIPAddressInformation ipInfo in ipInfoCol)
            {
                if (ipInfo.Address != null && ipInfo.Address.ToString() != "0.0.0.0" && Helpers.IsValidIP(ipInfo.Address.ToString()))
                {
                    return ipInfo.Address;
                }
            }

            return null;
        }

        private IPAddress GetInternalIP2()
        {
            string s = Dns.GetHostEntry(Dns.GetHostName()).AddressList
                .Where(a => !a.IsIPv6LinkLocal && !a.IsIPv6Multicast && !a.IsIPv6SiteLocal)
                .First()
                .ToString();

            return IPAddress.Parse(s);
        }

        // generate report
        public string GetReport()
        {
            string report = "";
            string div = "--------------------------------------------------\r\n\r\n";

            report += "This report was generated at " + DateTime.Now + "\r\n";
            report += div;
            report += "**SYSTEM\r\n";
            report += "Computer Name        : " + ComputerName + "\r\n";
            report += "Windows Version      : " + WindowsVersion + "\r\n";
            report += "Windows Architecture : " + WindowsArchitecture + "\r\n";
            report += "Memory Installed     : " + TotalInstalledMemory + " GB\r\n";
            report += "\r\n";
            report += "Username     : " + Username + "\r\n";
            report += "Domain       : " + Domain + "\r\n";
            report += "Logon Server : " + LogonServer + "\r\n";
            report += "\r\n";
            report += "Primary Network Device : " + NetworkDeviceName + "\r\n";
            report += "IP Address      : " + (InternalIPAddress != null ? InternalIPAddress.ToString() : "") + "\r\n";
            report += "Subnet Mask     : " + (SubnetMask != null ? SubnetMask.ToString() : "") + "\r\n";
            report += "Gateway Address : " + (GatewayAddress != null ? GatewayAddress.ToString() : "") + "\r\n";
            report += "DNS Address     : " + (DNSAddress != null ? DNSAddress.ToString() : "") + "\r\n";
            report += "External IP     : " + (ExternalIPAddress != null ? ExternalIPAddress.ToString() : "") + "\r\n";
            report += "Proxy Enabled   : " + HasProxyEnabled() + "\r\n";
            report += "PAC Enabled     : " + HasInternetAutoConfig() + "\r\n";
            report += div;

            report += "**NETWORK DIAGNOSTICS\r\n";
            var stats = NetworkStats;
            report += "Remote Target     : " + (stats.RemoteIP != null ? stats.RemoteIP.ToString() : "") + "\r\n";
            report += "Packet Loss %     : " + stats.PacketLossPercent + "\r\n";
            report += "Jitter            : " + stats.Jitter + "\r\n";
            report += "Average Latency   : " + stats.AverageLatency + "\r\n";
            report += "Effective Latency : " + stats.EffectiveLatency + "\r\n";
            report += "MOS Score         : " + stats.MOSScore + "\r\n";
            report += "New R-Score       : " + stats.ROSScore + "\r\n";
            report += "Telnet Status     : " + (TelnetStatus ? "Pass" : "Fail") + "\r\n";
            report += "Trace Route       : ";

            if (TraceRouteData.Count == 0)
            {
                report += "No Data\r\n\r\n\r\n";
            }
            else
            {
                report += "\r\n";
                foreach (var route in TraceRouteData)
                {
                    report += "\t" + route.TTL.ToString("00") + " -> " + route.Address + " (" + route.RoundTripTime + " ms)\r\n";
                }
            }

            report += div;

            report += "**INSTALLED APPLICATIONS\r\n";
            if (InstalledApps.Count > 0)
            {
                InstalledApps.Sort();

                foreach (string app in InstalledApps)
                {
                    report += app + "\r\n";
                }
            }
            else
            {
                report += "No Data";
            }
            report += div;

            report += "**VDI REGISTRY VALUES\r\n";
            if (VDIRegistry.Count > 0)
            {
                VDIRegistry.Sort();

                foreach (string reg in VDIRegistry)
                {
                    report += reg + "\r\n";
                }
            }
            report += div;

            report += "**END OF REPORT";
            return report;
        }
    }
}
