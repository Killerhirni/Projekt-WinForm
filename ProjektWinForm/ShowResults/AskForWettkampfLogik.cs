using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ProjektWinForm.ShowResults
{
    internal class AskForWettkampfLogik
    {
        private AskForWettkampf _application;
        private OleDbConnection conn;
        private OleDbDataAdapter da;
        private OleDbCommandBuilder cmd;
        private DataSet ds;
        private ProjektWinForm.Application.Application _form1Application;

        public void loadCombo(string text)
        {
            try
            {
                fillDataSet(text);
                if (text != "Wettkampf")
                {
                }
                else
                {
                    _application.comboBox1.Items.Clear();
                    foreach (DataRow dataRow in ds.Tables[0].Rows)
                    {
                        _application.comboBox1.Items.Add(dataRow.ItemArray[0]);
                    }
                }
            }
            catch (Exception e)
            {
                _application.Close();
            }
        }

        private void fillDataSet(string text)
        {
            try
            {
                conn = new OleDbConnection(
                    $"provider=Microsoft.ACE.OLEDB.12.0;Data Source = {Properties.Settings.Default.StartFile}");
                da = new OleDbDataAdapter($"select * from {text}", conn);
                cmd = new OleDbCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
            }
            catch (Exception e)
            {
                MessageBox.Show($"There Was an Error:\n{e.Message}", "Error", MessageBoxButtons.OK);
                _application.Close();
            }

        }

        public void setProperties(AskForWettkampf askForWettkampf,
            ProjektWinForm.Application.Application form1Application)
        {
            _application = askForWettkampf;
            _form1Application = form1Application;
        }

        public void setWettkampfID()
        {

            if (_application.comboBox1.Text != string.Empty)
            {
                _form1Application.WettkampfID = int.Parse(_application.comboBox1.Text);
            }
            else
            {
                MessageBox.Show("Bitte wählen sie eine WettkampfID aus.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}