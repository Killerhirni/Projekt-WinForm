using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using ProjektWinForm.Logik;

namespace ProjektWinForm.ManageWettkampf
{
    internal class ManageWettkampfFormLogic
    {
        private ManageWettkampfForm _application;
        private OleDbConnection conn;
        private OleDbDataAdapter da;
        private OleDbCommandBuilder cmd;
        private DataSet ds;
        private Logic lk;
        private OleDbCommand cmdd;

        public ManageWettkampfFormLogic(Logic lkk)
        {
            lk = lkk;
        }

        public void loadCombo(string text)
        {
            fillDataSet(text);
            if (text != "Strecke")
            {
                if (text != "Wettkampf")
                {
                    MessageBox.Show("PUFF!!", "PUFFFF", MessageBoxButtons.OK);
                }
                else
                {
                    if (_application.tabControl1.SelectedIndex.Equals(1))
                    {
                        _application.comboBox1.Items.Clear();
                        foreach (DataRow dataRow in ds.Tables[0].Rows)
                        {
                            _application.comboBox1.Items.Add(dataRow.ItemArray[0]);
                        }
                    }
                    else if (_application.tabControl1.SelectedIndex.Equals(2))
                    {
                        _application.comboBox4.Items.Clear();
                        _application.textBox2.Clear();
                        foreach (DataRow dataRow in ds.Tables[0].Rows)
                        {
                            _application.comboBox4.Items.Add(dataRow.ItemArray[0]);
                        }
                    }
                }
            }
            else
            {
                if (_application.tabControl1.SelectedIndex.Equals(0))
                {
                    _application.comboBox2.Items.Clear();
                    _application.textBox1.Clear();
                    foreach (DataRow dataRow in ds.Tables[0].Rows)
                    {
                        _application.comboBox2.Items.Add(dataRow.ItemArray[0]);
                    }
                }
                else if (_application.tabControl1.SelectedIndex.Equals(2))
                {
                    _application.comboBox3.Items.Clear();
                    foreach (DataRow dataRow in ds.Tables[0].Rows)
                    {
                        _application.comboBox3.Items.Add(dataRow.ItemArray[0]);
                    }
                }
            }
        }

        private void fillDataSet(string text)
        {
            conn = new OleDbConnection(
                $"provider=Microsoft.ACE.OLEDB.12.0;Data Source = {Properties.Settings.Default.StartFile}");
            da = new OleDbDataAdapter($"select * from {text}", conn);
            cmd = new OleDbCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
        }

        public void setProperties(object sender)
        {
            _application = (ManageWettkampfForm)sender;
        }

        public void addWettkampf()
        {
            if (_application.comboBox2.Text != string.Empty && _application.dateTimePicker1.Text != string.Empty && _application.textBox1.Text != string.Empty)
            {
                fillDataSet("Wettkampf");
                var dre = addNewWettkampf();
                if (dre.Length.Equals(0))
                {
                    UpdateTable();
                    int newWettkampf = getNewId();
                    addnewFahrerTable(newWettkampf);
                    messageBoxAdd();
                    runOut();
                }
            }
            else
            {
                MessageBox.Show("You left a Field Empty!", "Information", MessageBoxButtons.OK);
            }
        }

        private int getNewId()
        {
            fillDataSet("Wettkampf");
            var ID = 0;
            string s2 = $" StreckeID = {_application.comboBox2.Text} AND";
            string s3 = s2 + $" Bezeichnung = '{_application.textBox1.Text}'";
            DataRow[] dr = ds.Tables[0].Select($"{s3}");
            if (dr.Length == 1)
            {
                foreach (DataRow foundRow in dr)
                {
                    ID = (int) foundRow.ItemArray[0];
                }
            }

            return ID;
        }

        private void UpdateTable()
        {
            da.Update(ds);
        }

        private void addnewFahrerTable(int newWettkampf)
        {
            ds.Tables.Add($"Fahrer{newWettkampf.ToString()}");
        }

        private void runOut()
        {
            da.Update(ds);
            lk.UpdateAfterAdd("Wettkampf");
            loadCombo("Strecke");
        }

        private void messageBoxAdd()
        {
            MessageBox.Show($"Der Wettkampf wurde Eingepflegt.");
        }

        private DataRow[] addNewWettkampf()
        {
            string s2 = $" StreckeID = {_application.comboBox2.Text} AND";
            string s3 = s2 + $" Bezeichnung = '{_application.textBox1.Text}'";
            DataRow[] dr = ds.Tables[0].Select($"{s3}");
            
            if (dr.Length.Equals(0))
            {
                DataRow dre = ds.Tables[0].NewRow();
                dre["WettkampfDatum"] = _application.dateTimePicker1.Value.Date;
                dre["Bezeichnung"] = _application.textBox1.Text;
                dre["StreckeID"] = int.Parse(_application.comboBox2.Text);
                ds.Tables[0].Rows.Add(dre);
            }
            else
            {
                MessageBox.Show(
                    "Es ist bereits ein Wettkampf mit dieser Bezeichnung vorhanden.\nBitte löchen Sie diesen zuerst.",
                    "Information", MessageBoxButtons.OK);
            }
            return dr;
        }

        public void deleteWettkampf()
        {
            fillDataSet("Wettkampf");
            try
            {
                if (_application.comboBox1.Text != string.Empty)
                {
                    selectRowByInput();
                }
                else
                {
                    MessageBox.Show("Sie haben das Feld leer gelassen.", "Information", MessageBoxButtons.OK);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"There was an Error.\nErrormessage: {e.Message}", "Error",
                    MessageBoxButtons.OK);
            }

        }

        private void selectRowByInput()
        {
            DataRow[] foundRows = ds.Tables[0].Select($"WettkampfID = {_application.comboBox1.Text}");
            if (foundRows.Any())
            {
                var dr = deleteDialogQuestin();
                if (dr == DialogResult.Yes)
                {
                    deleteRowWithFittingValue(foundRows);
                    runOut();
                    loadCombo("Wettkampf");
                    messageBoxDelete();
                }
                else
                {
                    MessageBox.Show("Der vorgang wurde abgebrochen", "Abbruch", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show($"Der Wettkampf mit der WettkampfID '{_application.comboBox1.Text}' konnte nicht gefunden werden.",
                    "Error",
                    MessageBoxButtons.OK);
            }

        }

        private void deleteRowWithFittingValue(DataRow[] foundRows)
        {
            Console.WriteLine(foundRows);
            foreach (DataRow dataRow in foundRows)
            {
                dataRow.Delete();
                Console.WriteLine(dataRow);
            }
            // foundRows.AcceptChanges();
        }

        private void messageBoxDelete()
        {
            MessageBox.Show($"Der Wettkampf wurde gelöscht.");
        }

        private DialogResult deleteDialogQuestin()
        {
            DialogResult dr = MessageBox.Show(
                $"Wollen Sie den Wettkampf mit der WettkampfID '{_application.comboBox1.Text}' unwiederuflich Löschen?",
                "Question", MessageBoxButtons.YesNo);
            return dr;
        }


        public void editWettkampf()
        {
            fillWithValue();
        }

        private void fillWithValue()
        {
            if (_application.comboBox4.Text != string.Empty)
            {
                fillDataSet($"Wettkampf");
                DataRow[] foundRows = ds.Tables[0].Select($"WettkampfID = {_application.comboBox4.Text}");
                foreach (var foundRow in foundRows)
                {
                    _application.comboBox3.Text = foundRow.ItemArray[3].ToString();
                    _application.textBox3.Text = foundRow.ItemArray[2].ToString();
                    DateTime date = (DateTime)foundRow.ItemArray[1];
                    _application.dateTimePicker2.Text = foundRow.ItemArray[1].ToString();
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Wettkampf aus.", "Fehler", MessageBoxButtons.OK);
            }

        }

        public void saveEdit()
        {
            if (_application.comboBox4.Text != string.Empty && _application.comboBox3.Text != string.Empty &&
                _application.dateTimePicker1.Text != string.Empty && _application.textBox3.Text != string.Empty)
            {

                fillDataSet($"Wettkampf");
                DataRow[] foundRows = ds.Tables[0].Select($"WettkampfID = {_application.comboBox4.Text}");

                foreach (var foundRow in foundRows)
                {
                    fillWithNewValue(foundRow);
                    UpdateTable();
                    messageBoxEdit();
                    runOut();
                }

            }
            else
            {
                MessageBox.Show("Es müssen alle Felder befüllt sein!", "Error", MessageBoxButtons.OK);
            }
        }

        private void messageBoxEdit()
        {
            MessageBox.Show($"Der Wettkampf mit der WettkampfID:{_application.comboBox4.Text} wurde erfolgreich Bearbeitet.",
                "Information", MessageBoxButtons.OK);

        }

        private void fillWithNewValue(DataRow foundRow)
        {
            DataRow dr = foundRow;
            dr["DatumWettkampf"] = _application.dateTimePicker2.Text;
            dr["Bezeichnung"] = _application.textBox3.Text;
            dr["StreckeID"] = _application.comboBox3.Text;
        }

        public string setBez()
        {
            string bez = string.Empty;
            fillDataSet("Wettkampf");
            DataRow[] dr = new DataRow[] { };
            if (_application.tabControl1.SelectedIndex.Equals(1))
            {
                dr = ds.Tables[0].Select($"WettkampfID = {_application.comboBox1.Text}");
            }
            else if (_application.tabControl1.SelectedIndex.Equals(2))
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