using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SnapLog
{
    public partial class FormTraceRoute : Form
    {
        private static List<NetworkDiagnostics.NetworkDiagnostics.ICMP_REPLY> TraceData;

        public FormTraceRoute()
        {
            InitializeComponent();
        }

        public static void SetTraceData(List<NetworkDiagnostics.NetworkDiagnostics.ICMP_REPLY> t)
        {
            TraceData = t;
        }

        private void LoadTraceData(List<NetworkDiagnostics.NetworkDiagnostics.ICMP_REPLY> traceData)
        {
            if (traceData != null && traceData.Count > 0)
            {
                foreach (NetworkDiagnostics.NetworkDiagnostics.ICMP_REPLY reply in traceData)
                {
                    int ttl = reply.TTL;
                    string address = reply.Address;
                    string roundTripTime;

                    if (address == "Request timed out")
                    {
                        roundTripTime = "*";
                    }
                    else
                    {
                        roundTripTime = reply.RoundTripTime + " ms";
                    }

                    listTrace.Items.Add(new ListViewItem(new string[] { ttl.ToString(), address, roundTripTime }));
                }
            }
        }

        private void tmrRefreshData_Tick(object sender, EventArgs e)
        {
            listTrace.Items.Clear();
            if (FormMain.NetDiags != null)
            {
                LoadTraceData(FormMain.NetDiags.TraceRouteResult);
                if (FormMain.NetDiags.IP != null)
                {
                    this.Text = "Trace Route " + FormMain.NetDiags.IP.ToString();
                }
            }
        }
    }
}
