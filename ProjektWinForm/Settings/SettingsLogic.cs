using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ProjektWinForm.Logik;
using static ProjektWinForm.Properties.Settings;

namespace ProjektWinForm.Settings
{
    internal class SettingsLogic
    {
        private SettingsWinForm _application;
        public string startPath = Default.StartFile;
        private Logic lk;
        public Application.Application _form1Sender;

        public void SearchFile()
        {

            if (_application.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                startPath = _application.openFileDialog1.FileName;
            }

            if (startPath != string.Empty)
            {
                setPath();
            }
        }

        private void setPath()
        {
            _application.pathTextSettings.Text = startPath;
        }


        public void SetProperties(object sender)
        {
            _application = (SettingsWinForm)sender;
            _application.pathTextSettings.Text = Default.StartFile;
            lk = new Logic();
        }

        public void SafeFile()
        {
            try
            {

                if (Properties.Settings.Default.StartFile != _application.pathTextSettings.Text)
                {
                    if (Default.StartFile != startPath)
                    {
                        Default.StartFile = startPath;
                        Default.Save();
                    }

                    MessageBox.Show(
                        $"Die Einstellung wurde Gespeichert.\nIhre startfile ist unter'{Default.StartFile}' zu finden.",
                        "Information", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(
                        $"Sie haben bereits die Datei unter '{Properties.Settings.Default.StartFile}' ausgewählt.",
                        "Information", MessageBoxButtons.OK);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"There was a Problem \n {e.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        public void setSettingsToRegular()
        {
            Properties.Settings.Default.Mode = "Regular";
            Properties.Settings.Default.Save();
            _form1Sender.Size = new Size(190, 489);
        }

        public void setSettingsToAdvanced()
        {
            Properties.Settings.Default.Mode = "Advanced";
            Properties.Settings.Default.Save();
            _form1Sender.Size = new Size(1000,489);
        }

        public void setForm1(object sender)
        {
            _form1Sender = (Application.Application)sender;
        }
    }
}
