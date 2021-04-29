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
            settingsLogic.SafeFile();
            // Form1_Load(null, EventArgs.Empty);
        }

        public void setProperties(ProjektWinForm.Application.Application application)
        {
            _form1Application = application;
        }
    }
}
