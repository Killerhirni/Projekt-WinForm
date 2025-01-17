﻿namespace ProjektWinForm.Settings
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
            if (!Properties.Settings.Default.StartFile.Equals(pathTextSettings.Text))
            {
                settingsLogic.SafeFile();
            }
            else
            {
                MessageBox.Show("Sie haben die Datei bereits ausgewählt.", "Information", MessageBoxButtons.OK);
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
            if (Properties.Settings.Default.Mode != "Regular")
            {
                advanced_rbn_settings.Select();
            }
            else
            {
                regular_rbn_mode.Select();
            }
        }

        private void SearchFile_Click(object sender, EventArgs e)
        {
            settingsLogic.SearchFile();
        }

        private void saveStartMode_btn_Click(object sender, EventArgs e)
        {
            settingsLogic._form1Sender = _form1Application;
            if (advanced_rbn_settings.Checked != true)
            {
                settingsLogic.setSettingsToRegular();
            }
            else
            {
                settingsLogic.setSettingsToAdvanced();
            }
        }

        private void cancelSettings_btn_Click(object sender, EventArgs e)
        {
            var test = "Regular";
            if (advanced_rbn_settings.Checked == true)
            {
                test = "Advanced";}
            if (Properties.Settings.Default.Mode != test ||
                Properties.Settings.Default.StartFile != pathTextSettings.Text)
            {
                DialogResult re = MessageBox.Show(
                    "Alle nicht gespeicherten Elemente werden Gelöscht.\nWollen Sie die Einstellungen verlassen?",
                    "Question", MessageBoxButtons.YesNo);
                if (re == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
