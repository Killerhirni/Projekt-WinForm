using System;
using System.Windows.Forms;
using static ProjektWinForm.Properties.Settings;

namespace ProjektWinForm.Settings
{
    internal class SettingsLogic
    {
        private SettingsWinForm _application;
        public string startPath = Default.StartFile;

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
    }
}
