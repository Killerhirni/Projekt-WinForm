using System;
using System.Windows.Forms;
using static ProjektWinForm.Properties.Settings;

namespace ProjektWinForm.Logik
{
    internal class SettingsLogic
    {
        private Application.Application _application;
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
            _application = (Application.Application)sender;
            _application.pathTextSettings.Text = Default.StartFile;
        }

        public void SafeFile()
        {
            try
            {
                if (Default.StartFile != startPath)
                {
                    Default.StartFile = startPath;
                    Default.Save();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"There was a Problem \n {e.Message}", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
