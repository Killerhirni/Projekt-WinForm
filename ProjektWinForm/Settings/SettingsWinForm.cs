namespace ProjektWinForm.Settings
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class SettingsWinForm : Form
    {
        private SettingsLogic settingsLogic;
        private ProjektWinForm.Application.Application _form1Application;
        public SettingsWinForm()
        {
            InitializeComponent();
            settingsLogic = new SettingsLogic();
        }

        private void saveFileSettings_btn_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.StartFile != "none")
            {
                settingsLogic.SafeFile();
            }

            // Form1_Load(null, EventArgs.Empty);
        }

        public void setProperties(ProjektWinForm.Application.Application application)
        {
            _form1Application = application;
        }

        private void SettingsWinForm_Load(object sender, EventArgs e)
        {
            pathTextSettings.Text = $"{Properties.Settings.Default.StartFile}";
            settingsLogic.SetProperties(sender);
        }

        private void SearchFile_Click(object sender, EventArgs e)
        {
            settingsLogic.SearchFile();
        }
    }
}
