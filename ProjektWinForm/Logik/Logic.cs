using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Windows.Forms;
using ProjektWinForm.Properties;
using ProjektWinForm.Settings;

namespace ProjektWinForm.Logik
{
    public class Logic
    {
        public OleDbConnection conn;
        public OleDbDataAdapter da;
        public OleDbCommandBuilder cb;
        public DataSet ds;
        private BindingSource bs;
        private Application.Application _application;
        private SettingsLogic settingsLogic;
        private string startFile;

        public Logic()
        {
            settingsLogic = new SettingsLogic();
        }

        public void Load()
        {
            try
            {
                startFile = Properties.Settings.Default.StartFile;
                if (!Properties.Settings.Default.StartFile.Equals("none"))
                {
                    SetPathTextBox();
                }
                Connect();
                OpenConn();
                GetTables();
                CloseConn();
            }
            catch (Exception e)
            {
                MessageBox.Show($"There was a Problem by loading the Connection \n Error Message: \n {e.Message}",
                    "Error", MessageBoxButtons.OK);
            }
        }
        public void Load(string otherFile)
        {
            try
            {
                startFile = otherFile;
                if (otherFile != string.Empty)
                {
                    SetPathTextBox();
                }
                Connect();
                OpenConn();
                GetTables();
                CloseConn();
                ReleasePreview();
            }
            catch (Exception e)
            {
                MessageBox.Show($"There was a Problem by loading the Connection \n Error Message: \n {e.Message}",
                    "Error", MessageBoxButtons.OK);
            }
        }

        private void ReleasePreview()
        {
            if (_application.dataGridView1.DataSource != null)
            {
                _application.dataGridView1.DataSource = null;
            }
        }

        private void SetPathTextBox()
        {
            if (_application.pathText.Text != startFile)
            {
                _application.pathText.Text = startFile;
            }
        }

        public void Connect()
        {
            conn = new OleDbConnection($"provider=Microsoft.ACE.OLEDB.12.0;Data Source = {startFile}");
        }

        public void OpenConn()
        {
            conn.Open();
        }

        public void GetTables()
        {
            _application.comboBox1.Items.Clear();
            var tn = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            foreach(DataRow dataRow in tn.Rows)
            { 
                _application.comboBox1.Items.Add(dataRow.ItemArray[2].ToString());
            }

            _application.comboBox1.SelectedItem = _application.comboBox1.Items[0];
        }


        public void CloseConn()
        {
            conn.Close();
        }

        public void ShowTable()
        {
            if (startFile != "none" && startFile != string.Empty)
            {
                da = new OleDbDataAdapter($"select * FROM {_application.comboBox1.SelectedItem}", conn);
                cb = new OleDbCommandBuilder(da);
                ds = new DataSet();
                bs = new BindingSource();
                da.Fill(ds);
                bs.DataSource = ds.Tables[0];
                _application.dataGridView1.DataSource = ds.Tables[0];
                _application.bindingNavigator1.BindingSource = bs;
            }
            else
            {
                MessageBox.Show("Please select a Database", "Information", MessageBoxButtons.OK);
            }
        }

        public void Update()
        {
            if (startFile != "none")
            {
                try
                {
                    da.Update(ds.Tables[0]);
                }
                catch (Exception e)
                {
                    MessageBox.Show(
                        $"There was a Error while Update the Database Table. \n Error Message: \n{e.Message}", "Error",
                        MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please select a Database", "Information", MessageBoxButtons.OK);
            }
        }

        public void SelectPath()
        {
            try
            {


                var otherFile = string.Empty;
                if (_application.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    otherFile = _application.openFileDialog1.FileName;
                }
                DialogResult dialogResult =
                    MessageBox.Show(
                        "If you accept your current File will close. \nAre you Sure you want to Open another File?",
                        "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (otherFile != string.Empty)
                    {
                        Load(otherFile);
                    }
                }
                else
                {
                    MessageBox.Show("You denied.\nYour File is still Open.", "Information", MessageBoxButtons.OK);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"There is a Problem by loading the Database. \n Please Contact the Administrator. \n Error Message: \n {e.Message}",
                    "Error", MessageBoxButtons.OK);
            }
        }

        public void SetProperties(object sender)
        {
            _application = (Application.Application)sender;
        }

        public void openTable()
        {
            if (startFile != "none" && startFile != string.Empty)
            {
                Process.Start(startFile);
                MessageBox.Show("Process will Start", "Information", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Please select a Database", "Information", MessageBoxButtons.OK);
            }
        }

        public void UpdateAfterAddTeam()
        {
            da = new OleDbDataAdapter("select * from Team", conn);
            cb = new OleDbCommandBuilder(da);
            ds = new DataSet();
            bs = new BindingSource();
            da.Fill(ds);
            bs.DataSource = ds.Tables[0];
            _application.dataGridView1.DataSource = ds.Tables[0];
            _application.bindingNavigator1.BindingSource = bs;
        }
    }
}