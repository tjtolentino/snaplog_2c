using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SnapLog
{
    public sealed partial class formAbout : Form
    {
        public formAbout()
        {
            InitializeComponent();
        }

        private void AboutBox1_Load(object sender, EventArgs e)
        {
            // Set the title of the form.
            string applicationTitle = AssemblyTitle;
            if (string.IsNullOrEmpty(applicationTitle))
            {
                applicationTitle = Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
            this.Text = string.Format("About {0}", applicationTitle);

            // Initialize all of the text displayed on the About Box.
            this.LabelProductName.Text = AssemblyProduct;
            this.LabelVersion.Text = string.Format("Version {0}", AssemblyVersion);
            this.LabelCopyright.Text = AssemblyCopyright;
            this.LabelCompanyName.Text = AssemblyCompany;
            this.TextBoxDescription.Text = AssemblyDescription;
            this.PictureBox1.Image = Properties.Resources.TeleTech;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (!string.IsNullOrEmpty(titleAttribute.Title))
                    {
                        return titleAttribute.Title;
                    }
                }
                return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}
