using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using ProjektWinForm.Logik;

namespace ProjektWinForm.StreckenZeit
{
    internal class ManageStreckenZeitWinFormLogic
    {
        private Logic lk;
        private ManageStreckenZeitWinForm _application;
        private ProjektWinForm.Application.Application _form1Application;
        private OleDbConnection conn;
        private OleDbDataAdapter da;
        private OleDbCommandBuilder cmd;
        private DataSet ds;

        public ManageStreckenZeitWinFormLogic(Logic lkk)
        {
            lk = lkk;
        }

        public void setProperties(ProjektWinForm.Application.Application form1Application, ManageStreckenZeitWinForm manageStreckenZeitWinForm)
        {
            _application = manageStreckenZeitWinForm;
            _form1Application = form1Application;
        }

        public void loadCombo(string text)
        {
            try
            {
                fillDataSet(text);
                if (_application.tabControl1.SelectedIndex.Equals(0))
                {
                    _application.comboBox1.Items.Clear();
                    foreach (DataRow dataRow in ds.Tables[0].Rows)
                    {
                        if (!_application.comboBox1.Items.Contains(dataRow.ItemArray[2]))
                        {
                            _application.comboBox1.Items.Add(dataRow.ItemArray[2]);
                        }
                    }
                }
                else if (_application.tabControl1.SelectedIndex.Equals(1))
                {
                    _application.comboBox4.Items.Clear();
                    foreach (DataRow dataRow in ds.Tables[0].Rows)
                    {
                        if (!_application.comboBox4.Items.Contains(dataRow.ItemArray[2]))
                        {
                            _application.comboBox4.Items.Add(dataRow.ItemArray[2]);
                        }
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
                MessageBox.Show($"There was an Error\nErrorMessage:\n{e.Message}", "Error", MessageBoxButtons.OK);
                _application.Close();
            }

        }

        public void AddTime()
        {
            if (_application.comboBox1.Text != string.Empty && _application.comboBox2.Text != string.Empty && _application.dateTimePicker1.Value.TimeOfDay.ToString() != "00:00:00")
            {
                fillDataSet("Teilnahme");
                DataRow[] dr = ds.Tables[0]
                    .Select(
                        $"WettkampfID = {int.Parse(_application.comboBox1.Text)} AND Startnummer = {int.Parse(_application.comboBox2.Text)}");
                if (dr.Any()) {
                    foreach (DataRow dataRow in dr)
                    {
                        dataRow["Streckenzeit"] = _application.dateTimePicker1.Value;
                    }
                    runOut();
                    messageBoxAdd();
                    _application.comboBox2.Items.Clear();
                }
                else
                {
                    MessageBox.Show(
                        "Der Fahrer konnte nicht zu diesem Wettkampf gefunden werden. \nBitte wenden Sie sich an den Supprt.",
                        "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Bitte füllen Sie alle felder aus.", "Error", MessageBoxButtons.OK);
            }
        }

        private void messageBoxAdd()
        {
            MessageBox.Show(
                $"Die Streckenzeit für die Startnummer: {_application.comboBox2.Text} wurde erfolgreich hinzugefügt.",
                "Information", MessageBoxButtons.OK);
        }

        public void loadComboStartnummer(string text)
        {
            if (_application.tabControl1.SelectedIndex.Equals(0))
            {
                fillDataSet(text);
                DataRow[] dr = ds.Tables[0].Select($"WettkampfID = {_application.comboBox1.Text}");
                if (dr.Any())
                {
                    foreach (var dataRow in dr)
                    {
                        _application.comboBox2.Items.Add(dataRow.ItemArray[1]);
                    }
                }
                else
                {
                    MessageBox.Show("Für diesen Wettkampf wurden noch keine Fahrer angelegt.\nBitte legen Sie welche an.",
                        "Error", MessageBoxButtons.OK);
                }
            }
            else if(_application.tabControl1.SelectedIndex.Equals(1))
            {
                fillDataSet(text);
                DataRow[] dr = ds.Tables[0].Select($"WettkampfID = '{_application.comboBox4.Text}'");
                if (dr.Any())
                {
                    foreach (var dataRow in dr)
                    {
                        _application.comboBox3.Items.Add(dataRow.ItemArray[1]);
                    }
                }
                else
                {
                    MessageBox.Show("Für diesen Wettkampf wurden noch keine Fahrer angelegt.\nBitte legen Sie welche an.",
                        "Error", MessageBoxButtons.OK);
                }
            }
        }
        private void runOut()
        {
            da.Update(ds);
            lk.UpdateAfterAdd("Teilnahme", 1);
            loadCombo("Teilnahme");
        }

        public void editTime()
        {
            if (_application.comboBox4.Text != string.Empty && _application.comboBox3.Text != string.Empty && _application.dateTimePicker2.Value.TimeOfDay.ToString() != "00:00:00")
            {
                fillDataSet("Teilnahme");
                DataRow[] dr = ds.Tables[0]
                    .Select(
                        $"WettkampfID = {int.Parse(_application.comboBox4.Text)} AND Startnummer = {int.Parse(_application.comboBox3.Text)}");
                if (dr.Any())
                {
                    foreach (DataRow dataRow in dr)
                    {
                        dataRow["Streckenzeit"] = _application.dateTimePicker2.Value;
                    }
                    runOut();
                    messageBoxEdit();
                    _application.comboBox3.Items.Clear();
                    _application.dateTimePicker2.Text = "00:00:00";
                }
                else
                {
                    MessageBox.Show(
                        "Der Fahrer konnte nicht zu diesem Wettkampf gefunden werden. \nBitte wenden Sie sich an den Supprt.",
                        "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Bitte füllen Sie alle felder aus.", "Error", MessageBoxButtons.OK);
            }
        }

        private void messageBoxEdit()
        {
            MessageBox.Show(
                $"Die Streckenzeit von der Startnummer: {_application.comboBox3.Text} wurde erfolgreich editiert.",
                "Information", MessageBoxButtons.OK);
        }

        public void showTime()
        {
            if (_application.comboBox4.Text != string.Empty && _application.comboBox3.Text != string.Empty)
            {
                fillDataSet("Teilnahme");
                DataRow[] dr = ds.Tables[0]
                    .Select(
                        $"WettkampfID = {int.Parse(_application.comboBox4.Text)} AND Startnummer = {int.Parse(_application.comboBox3.Text)}");
                if (dr.Any())
                {
                    foreach (DataRow dataRow in dr)
                    {
                        _application.dateTimePicker2.Text = dataRow.ItemArray[3].ToString();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Der Fahrer konnte nicht zu diesem Wettkampf gefunden werden. \nBitte wenden Sie sich an den Supprt.",
                        "Error", MessageBoxButtons.OK);
                }
            }
        }

        public string setBez()
        {
            string bez = string.Empty;
            fillDataSet("Wettkampf");
            DataRow[] dr = new DataRow[] { };
            if (_application.tabControl1.SelectedIndex.Equals(0))
            {
                dr = ds.Tables[0].Select($"WettkampfID = {_application.comboBox1.Text}");
            }
            else if (_application.tabControl1.SelectedIndex.Equals(1))
            {
                dr = ds.Tables[0].Select($"WettkampfID = {_application.comboBox4.Text}");
            }

            foreach (var dataRow in dr)
            {
                bez = dataRow.ItemArray[2].ToString();
            }

            return bez;

        }
    }
}