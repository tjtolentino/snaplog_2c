using System;
using System.IO;
using System.Windows.Forms;

namespace SnapLog
{
    public partial class FormLoadURL : Form
    {
        public FormLoadURL()
        {
            InitializeComponent();
        }

        private void FormLoadURL_Load(object sender, EventArgs e)
        {
            string remoteDir = Path.Combine(Application.StartupPath, "remote");
            listFiles.Items.Clear();

            if (Directory.Exists(remoteDir))
            {
                DirectoryInfo di = new DirectoryInfo(remoteDir);
                FileInfo[] diar1 = di.GetFiles("*.txt");
                foreach (FileInfo dra in diar1)
                {
                    listFiles.Items.Add(dra.ToString());
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (listFiles.SelectedItems.Count > 0)
            {
                string selectedFile = listFiles.SelectedItem.ToString();
                string remotePath = Path.Combine(Application.StartupPath, "remote", selectedFile);
                string filePath = File.Exists(remotePath) ? remotePath : Path.Combine(Application.StartupPath, selectedFile);

                FormMain.Instance?.LoadUrlFile(filePath);
                this.Close();
            }
        }
    }
}
