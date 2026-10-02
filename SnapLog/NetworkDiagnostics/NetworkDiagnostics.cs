using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SnapLog.NetworkDiagnostics
{
    public class NetworkDiagnostics
    {
        //------------------------------------- PUBLIC PROPERTIES
        public List<ICMP_REPLY> TraceRouteResult { get; set; } = new List<ICMP_REPLY>();
        public string TraceRouteStatus { get; set; } = "Idle";
        public bool TelnetResult { get; set; }
        public NETWORKDIAGNOSTICTEST_REPLY NetworkDiagnosticTestResult { get; set; }

        private bool CancelTraceroute = false;
        private IPAddress RemoteIP;

        public IPAddress IP
        {
            get
            {
                return RemoteIP;
            }
            set
            {
                RemoteIP = value;
                TelnetResult = false;
                CancelTraceroute = true;
                TraceRouteResult.Clear();
            }
        }

        private int RemotePort;

        public int Port
        {
            get
            {
                return RemotePort;
            }
            set
            {
                RemotePort = value;
                TelnetResult = false;
                CancelTraceroute = true;
                TraceRouteResult.Clear();
            }
        }

        //------------------------------------- DATA TYPES
        public struct NETWORKDIAGNOSTICTEST_REPLY
        {
            public IPAddress RemoteIP;
            public double AverageLatency;
            public double EffectiveLatency;
            public double Jitter;
            public double MOSScore;
            public double PacketLossPercent;
            public double ROSScore;
        }

        public struct ICMP_REPLY
        {
            public int TTL;
            public string Address;
            public long Status;
            public long RoundTripTime;
        }

        //------------------------------------- PUBLIC SUBS
        public NetworkDiagnostics()
        {
            RemoteIP = IPAddress.Parse("208.69.34.231"); // defaults to OpenDNS
            RemotePort = 80;
            CancelTraceroute = true;
        }

        public NetworkDiagnostics(IPAddress ip, int port = 80)
        {
            RemoteIP = ip;
            RemotePort = port;
            CancelTraceroute = true;
        }

        public void RunAllTests()
        {
            NetworkDiagnosticTestResult = NetworkDiagnosticTest(RemoteIP);
            TelnetResult = Telnet(RemoteIP, RemotePort);
            TraceRouteResult = TraceRoute(RemoteIP);
        }

        public void RunNetworkDiagnosticTest()
        {
            NetworkDiagnosticTestResult = NetworkDiagnosticTest(RemoteIP);
        }

        public void RunTelnet()
        {
            TelnetResult = Telnet(RemoteIP, RemotePort);
        }

        public void RunTraceRoute(IPAddress ip)
        {
            CancelTraceroute = true;
            TraceRouteResult.Clear();
            TraceRouteResult = TraceRoute(ip);
        }

        //------------------------------------- PUBLIC FUNCTIONS
        public NETWORKDIAGNOSTICTEST_REPLY GetNetworkDiagnosticTest(IPAddress ip)
        {
            return NetworkDiagnosticTest(ip);
        }

        public bool GetTelnet(IPAddress ip, int port)
        {
            return Telnet(ip, port);
        }

        public List<ICMP_REPLY> GetTraceRoute(IPAddress ip)
        {
            CancelTraceroute = true;
            return TraceRoute(ip);
        }

        //------------------------------------- PRIVATE FUNCTIONS
        private static NETWORKDIAGNOSTICTEST_REPLY NetworkDiagnosticTest(IPAddress ip)
        {
            Ping ping = new Ping();
            List<PingReply> replies = new List<PingReply>();
            NETWORKDIAGNOSTICTEST_REPLY mData = new NETWORKDIAGNOSTICTEST_REPLY();

            int pingQty = Properties.Settings.Default.NetDiagPingQty;

            for (int i = 0; i < pingQty; i++)
            {
                replies.Add(ping.Send(ip));
                Thread.Sleep(500);
            }

            double packetLossPercent = NetworkDiagnostics.PacketLossPercent(replies);
            double averageLatency = NetworkDiagnostics.AverageLatency(replies);
            double jitter = NetworkDiagnostics.Jitter(replies);
            double n = averageLatency + jitter * 2 + 10;
            double n1 = n >= 160 ? 93.2 - (n - 120) / 10 : 93.2 - n / 40;
            n1 = n1 - packetLossPercent * 2.5;
            double n2 = 1 + 0.035 * n1 + 0.000007 * n1 * (n1 - 60) * (100 - n1);

            mData.RemoteIP = ip;
            mData.ROSScore = n1;
            mData.PacketLossPercent = packetLossPercent;
            mData.AverageLatency = averageLatency;
            mData.Jitter = jitter;
            mData.EffectiveLatency = n;
            mData.MOSScore = n2;

            return mData;
        }

        public static double RScore(IPAddress ip, CodecType codec, int nRetries)
        {
            Ping ping = new Ping();
            List<PingReply> replies = new List<PingReply>();
            double n = 0;
            int n1 = 60;
            long r1 = 0;

            int packetInterval = codec.PacketInterval + 10;

            for (int i = 0; i < nRetries; i++)
            {
                PingReply reply = ping.Send(ip);
                r1 = reply.RoundtripTime;
                replies.Add(reply);
                Thread.Sleep(500);
            }

            int n2 = 0;
            double n3 = 0;
            double n4 = 0;
            double n5 = 0;
            double n6 = 0;
            double n7 = 0;
            long r2 = 0;

            foreach (PingReply reply in replies)
            {
                if (reply.Status != IPStatus.Success) n2 += 1;
                r2 = reply.RoundtripTime;
                n3 += n2;
                n4 += r2;
                n5 += 0.5 * r2;
                n6 += n2;
                if (r2 - r1 - (3 * codec.PacketInterval) >= 0)
                {
                    n7 += 1;
                }
            }

            double c1 = 0;
            double c2 = 0;
            double c3 = 0;

            if (replies.Count > 0)
            {
                c1 = n5 / replies.Count;
                c2 = n6 / replies.Count;
                c3 = n7 / replies.Count;
            }

            double n8 = c1 + packetInterval + n1;
            double n9 = n8 - 117.3 < 0 ? 0 : 1;
            double n10 = c2 + (1 - c2) * c3;
            double y1 = codec.Y1 + codec.Y2 + Math.Log(1 + codec.Y3 * n10);
            double n11 = 0.024 * n8 + 0.11 * (n8 - 177.3) * n9;
            n = 94.2 - y1 - n11;

            if (n <= 0) n = 0;
            return n;
        }

        private static double PacketLossPercent(List<PingReply> replies)
        {
            double n = 0;
            foreach (var reply in replies)
            {
                if (reply.Status == IPStatus.Success)
                {
                    n += 1;
                }
            }

            return replies.Count > 0 ? 1 - n / replies.Count : 0;
        }

        private static double AverageLatency(List<PingReply> replies)
        {
            long n = 0;
            long roundtripTime = 0;

            foreach (var reply in replies)
            {
                if (reply.Status != IPStatus.Success)
                {
                    n += 1;
                }
                else
                {
                    roundtripTime += reply.RoundtripTime;
                }
            }

            return replies.Count <= n ? 0 : (double)roundtripTime / (replies.Count - n);
        }

        private static double Jitter(List<PingReply> replies)
        {
            double n = 0;
            double roundtripTime = 0;

            foreach (var reply in replies)
            {
                if (roundtripTime != 0)
                {
                    n += Math.Abs(reply.RoundtripTime - roundtripTime);
                }
                roundtripTime = reply.RoundtripTime;
            }

            return replies.Count > 1 ? n / (replies.Count - 1) : 0;
        }

        // TRACEROUTE FUNCTION
        private List<ICMP_REPLY> TraceRoute(IPAddress ip)
        {
            int ttl = 1;
            List<ICMP_REPLY> pingResults = new List<ICMP_REPLY>();
            ICMP_REPLY pingResult = new ICMP_REPLY();
            PingReply reply;
            string currentAddress = "0.0.0.0";
            int maxHops = Properties.Settings.Default.TraceMaxHops;

            TraceRouteStatus = "Started";

            do
            {
                if (ip.ToString() != RemoteIP.ToString() || CancelTraceroute)
                {
                    TraceRouteResult.Clear();
                    pingResults.Clear();
                    TraceRouteStatus = "Cancelled";
                    ttl = 1;
                    ip = RemoteIP;
                    CancelTraceroute = false;
                }
                else
                {
                    using (Ping pinger = new Ping())
                    {
                        int pingTimeout = Properties.Settings.Default.TracePingTimeout;
                        string pingData = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                        byte[] buffer = Encoding.ASCII.GetBytes(pingData);
                        PingOptions pingerOptions = new PingOptions(ttl, true);

                        reply = pinger.Send(ip, pingTimeout, buffer, pingerOptions);
                        pingResult.TTL = ttl;

                        TraceRouteStatus = "Ongoing";
                        if (reply.Status == IPStatus.Success || reply.Status == IPStatus.TtlExpired)
                        {
                            pingResult.Address = reply.Address != null ? reply.Address.ToString() : "0.0.0.0";
                            pingResult.Status = 1;
                            PingReply r2 = pinger.Send(ip);
                            pingResult.RoundTripTime = r2 != null ? r2.RoundtripTime : 0;
                        }
                        else if (reply.Status == IPStatus.TimedOut)
                        {
                            pingResult.Address = "Request timed out";
                            pingResult.Status = -1;
                            pingResult.RoundTripTime = 0;
                        }

                        pingResults.Add(pingResult);
                        TraceRouteResult = new List<ICMP_REPLY>(pingResults);
                        ttl += 1;

                        if (reply.Address == null)
                        {
                            currentAddress = "0.0.0.0";
                        }
                        else
                        {
                            currentAddress = reply.Address.ToString();
                        }
                    }
                }
            } while (ttl <= maxHops && currentAddress != ip.ToString());

            TraceRouteStatus = "Completed";
            return pingResults;
        }

        // TELNET FUNCTION
        private static bool Telnet(IPAddress ip, int port = 80)
        {
            bool rVal = false;
            TcpClient client = new TcpClient();
            int timeOut = Properties.Settings.Default.TelnetTimeout;

            try
            {
                if (!client.ConnectAsync(ip.ToString(), port).Wait(timeOut))
                {
                    rVal = false;
                }
                else
                {
                    rVal = true;
                }
            }
            catch
            {
                rVal = false;
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                    client = null;
                }
            }

            return rVal;
        }
    }
}
