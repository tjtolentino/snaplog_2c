using System.ComponentModel;

namespace SnapLog
{
    public class AppSettings
    {
        [Category("Export"), RefreshProperties(RefreshProperties.All)]
        public bool GroupPolicy
        {
            get
            {
                return Properties.Settings.Default.GroupPolicy;
            }
            set
            {
                Properties.Settings.Default.GroupPolicy = value;
            }
        }

        [Category("Network Tests"), RefreshProperties(RefreshProperties.All)]
        public int TelnetTimeout
        {
            get
            {
                return Properties.Settings.Default.TelnetTimeout;
            }
            set
            {
                Properties.Settings.Default.TelnetTimeout = value;
            }
        }

        [Category("Network Tests"), RefreshProperties(RefreshProperties.All)]
        public int NetDiagPingQty
        {
            get
            {
                return Properties.Settings.Default.NetDiagPingQty;
            }
            set
            {
                Properties.Settings.Default.NetDiagPingQty = value;
            }
        }

        [Category("Network Tests"), RefreshProperties(RefreshProperties.All)]
        public int TraceMaxHops
        {
            get
            {
                return Properties.Settings.Default.TraceMaxHops;
            }
            set
            {
                Properties.Settings.Default.TraceMaxHops = value;
            }
        }

        [Category("Network Tests"), RefreshProperties(RefreshProperties.All)]
        public int TracePingTimeout
        {
            get
            {
                return Properties.Settings.Default.TracePingTimeout;
            }
            set
            {
                Properties.Settings.Default.TracePingTimeout = value;
            }
        }
    }
}
