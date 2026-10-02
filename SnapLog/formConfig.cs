using System;
using System.Windows.Forms;

namespace SnapLog
{
    public partial class formConfig : Form
    {
        public formConfig()
        {
            InitializeComponent();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            AppSettings mySettings = new AppSettings();
            SettingsGrid.SelectedObject = mySettings;
        }
    }
}
