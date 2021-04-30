using ProjektWinForm.Logik;
using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace ProjektWinForm.ManageFahrer
{
    public class ManageFahrerFormLogic
    {
        private OleDbConnection conn;
        private OleDbDataAdapter da;
        private OleDbCommandBuilder cmd;
        private DataSet ds;
        private ManageFahrerForm _application;
        private Logic lk;

        public ManageFahrerFormLogic(Logic lkk)
        {
            lk = lkk;
        }
        public void loadCombo(string text)
        {
            fillDataSet(text);
            if (text != "Wettkampf")
            {
                if (text != "Team")
                {
                    if (_application.tabControl1.SelectedIndex.Equals(1))
                    {
                        _application.comboBox2.Items.Clear();
                    }
                    else if (_application.tabControl1.SelectedIndex.Equals(0))
                    {
                        _application.comboBox1.Items.Clear();
                    }
                    else if (_application.tabControl1.SelectedIndex.Equals(2))
                    {
                        _application.comboBox3.Items.Clear();
                    }

                    foreach (DataRow dataRow in ds.Tables[0].Rows)
                    {
                        if (_application.tabControl1.SelectedIndex.Equals(1))
                        {
                            _application.comboBox2.Items.Add(dataRow.ItemArray[0]);
                        }
                        else if (_application.tabControl1.SelectedIndex.Equals(0))
                        {
                            _application.comboBox1.Items.Add(dataRow.ItemArray[0]);
                        }
                        else if (_application.tabControl1.SelectedIndex.Equals(2))
                        {
                            _application.comboBox3.Items.Add(dataRow.ItemArray[0]);
                        }
                    }
                }
                else
                {
                    _application.comboBox7.Items.Clear();
                    foreach (DataRow dataRow in ds.Tables[0].Rows)
                    {
                        _application.comboBox7.Items.Add(dataRow.ItemArray[0]);
                    }
                }
            }
            else if (_application.tabControl1.SelectedIndex.Equals(0))
            {
                _application.comboBox4.Items.Clear();
                foreach (DataRow dataRow in ds.Tables[0].Rows)
                {
                    _application.comboBox4.Items.Add(dataRow.ItemArray[0]);
                }
            }
            else if (_application.tabControl1.SelectedIndex.Equals(1))
            {
                _application.comboBox5.Items.Clear();
                foreach (DataRow dataRow in ds.Tables[0].Rows)
                {
                    _application.comboBox5.Items.Add(dataRow.ItemArray[0]);
                }
            }
            else if (_application.tabControl1.SelectedIndex.Equals(2))
            {
                _application.comboBox6.Items.Clear();
                foreach (DataRow dataRow in ds.Tables[0].Rows)
                {
                    _application.comboBox6.Items.Add(dataRow.ItemArray[0]);
                }
            }
        }

        public void fillDataSet(string text)
        {
            conn = new OleDbConnection(
                $"provider=Microsoft.ACE.OLEDB.12.0;Data Source = {Properties.Settings.Default.StartFile}");
            da = new OleDbDataAdapter($"select * from {text}", conn);
            cmd = new OleDbCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
        }

        public void setProperties(ManageFahrerForm manageFahrerForm)
        {
            _application = manageFahrerForm;
        }

        public void addFahrerToWettkampf()
        {
            if (_application.comboBox4.Text != string.Empty && _application.comboBox1.Text != string.Empty && _application.textBox2.Text != string.Empty && _application.textBox3.Text != string.Empty &&
                _application.textBox4.Text != string.Empty && _application.textBox5.Text != string.Empty &&
                _application.textBox6.Text != string.Empty)
            {
                fillDataSet($"Fahrer{_application.comboBox4.Text}");
                addNewFahrer();
                messageBoxAdd();
                runOut();
            }
            else
            {
                MessageBox.Show("You left a Field Empty!", "Information", MessageBoxButtons.OK);
            }
        }

        private void runOut()
        {
            da.Update(ds);
            if (_application.tabControl1.SelectedIndex.Equals(0))
            {
                lk.UpdateAfterAdd($"Fahrer{_application.comboBox4.Text}");
            }
            else if (_application.tabControl1.SelectedIndex.Equals(1))
            {
                lk.UpdateAfterAdd($"Fahrer{_application.comboBox5.Text}");
                _application.comboBox2.Items.Clear();
                loadCombo($"Fahrer{_application.comboBox5.Text}");
            }
            else if (_application.tabControl1.SelectedIndex.Equals(2))
            {
                lk.UpdateAfterAdd($"Fahrer{_application.comboBox6.Text}");
            }
        }

        private void messageBoxAdd()
        {
            MessageBox.Show($"Der Fahrer wurde Eingepflegt.");
        }

        private void addNewFahrer()
        {
            DataRow dr = ds.Tables[0].NewRow();
            dr["TeamID"] = int.Parse(_application.comboBox1.Text);
            dr["FahrerAlter"] = int.Parse(_application.textBox2.Text);
            dr["Straße"] = _application.textBox3.Text;
            dr["Hausnummer"] = _application.textBox4.Text;
            dr["Ort"] = _application.textBox6.Text;
            dr["PLZ"] = int.Parse(_application.textBox5.Text);
            ds.Tables[0].Rows.Add(dr);
        }

        public void deleteFahrer()
        {
            if (_application.comboBox5.Text != string.Empty)
            {
                fillDataSet($"Fahrer{_application.comboBox5.Text}");
                try
                {
                    if (_application.comboBox2.Text != string.Empty)
                    {
                        selectRowByInput();
                    }
                    else
                    {
                        MessageBox.Show("Bitte wählen Sie eine Startnummer aus.", "Information", MessageBoxButtons.OK);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"There was an Error.\nErrormessage: {e.Message}", "Error",
                        MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show($"Bitte wählen Sie einen Wettkampf aus.", "Error", MessageBoxButtons.OK);
            }
        }

        private void selectRowByInput()
        {

            DataRow[] foundRows = ds.Tables[0].Select($"Startnummer = {_application.comboBox2.Text}");
            if (foundRows.Any())
            {
                deleteRowWithFittingValue(foundRows);
                var dr = deleteDialogQuestin();
                if (dr == DialogResult.Yes)
                {
                    messageBoxDelete();
                    runOut();
                }
                else
                {
                    MessageBox.Show("Der vorgang wurde abgebrochen", "Abbruch", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show($"Die Startnummer '{_application.comboBox3.Text}' konnte nicht gefunden werden.",
                    "Error",
                    MessageBoxButtons.OK);
            }


        }

        private void messageBoxDelete()
        {
            MessageBox.Show($"Der Fahrer wurde gelöscht.");
        }

        private DialogResult deleteDialogQuestin()
        {
            DialogResult dr = MessageBox.Show(
                $"Wollen Sie den Fahrer mit der Startnummer '{_application.comboBox2.Text}' unwiederuflich Löschen?",
                "Question", MessageBoxButtons.YesNo);
            return dr;
        }

        private void deleteRowWithFittingValue(DataRow[] foundRows)
        {
            foreach (var dataRow in foundRows)
            {
                dataRow.Delete();
            }
        }

        public void saveEditedRow()
        {
            if (_application.comboBox6.Text != string.Empty && _application.comboBox7.Text != string.Empty &&
                _application.textBox10.Text != string.Empty &&
                _application.textBox11.Text != string.Empty && _application.textBox12.Text != string.Empty &&
                _application.textBox13.Text != string.Empty && _application.textBox14.Text != string.Empty)
            {
                fillDataSet($"Fahrer{_application.comboBox6.Text}");
                DataRow[] foundRows = ds.Tables[0].Select($"Startnummer = {_application.comboBox3.Text}");
                foreach (var foundRow in foundRows)
                {
                    if (_application.comboBox6.Text != string.Empty && _application.comboBox7.Text != string.Empty &&
                        _application.textBox10.Text != string.Empty &&
                        _application.textBox11.Text != string.Empty && _application.textBox12.Text != string.Empty &&
                        _application.textBox13.Text != string.Empty && _application.textBox14.Text != string.Empty)
                    {
                        fillWithNewValue(foundRow);
                        da.Update(ds.Tables[0]);
                    }
                    else
                    {
                        MessageBox.Show("Sie haben ein Feld leer gelassen, es müssen ale felder gefüllt sein!.",
                            "Error",
                            MessageBoxButtons.OK);
                    }
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
            MessageBox.Show($"Der Fahrer mit der Startnummer:{_application.comboBox3.Text} wurde erfolgreich Bearbeitet.",
                "Information", MessageBoxButtons.OK);
        }

        private void fillWithNewValue(DataRow foundRow)
        {
            DataRow dr = foundRow;
            dr["Straße"] = _application.textBox13.Text;
            dr["Hausnummer"] = _application.textBox12.Text;
            dr["Ort"] = _application.textBox10.Text;
            dr["PLZ"] = _application.textBox11.Text;
            dr["FahrerAlter"] = _application.textBox14.Text;
        }

        public string setBez()
        {
            string bez = string.Empty;
            fillDataSet("Wettkampf");
            DataRow[] dr = new DataRow[] { };
            if (_application.tabControl1.SelectedIndex.Equals(0))
            {
                dr = ds.Tables[0].Select($"WettkampfID = {_application.comboBox4.Text}");
            }
            else if (_application.tabControl1.SelectedIndex.Equals(1))
            {
                dr = ds.Tables[0].Select($"WettkampfID = {_application.comboBox5.Text}");
            }
            else if (_application.tabControl1.SelectedIndex.Equals(2))
            {
                dr = ds.Tables[0].Select($"WettkampfID = {_application.comboBox6.Text}");
            }

            foreach (var dataRow in dr)
            {
                bez = dataRow.ItemArray[2].ToString();
            }

            return bez;
        }

        public void fillTextBoxes()
        {
            if (_application.comboBox6.Text != string.Empty)
            {
                if (_application.comboBox3.Text != string.Empty)
                {
                    if (_application.comboBox7.Text != string.Empty)
                    {
                        fillDataSet($"Fahrer{_application.comboBox6.Text}");
                        DataRow[] foundRows = ds.Tables[0].Select($"Startnummer = {_application.comboBox3.Text}");
                        foreach (var foundRow in foundRows)
                        {
                            _application.textBox10.Text = foundRow.ItemArray[3].ToString();
                            _application.textBox11.Text = foundRow.ItemArray[4].ToString();
                            _application.textBox12.Text = foundRow.ItemArray[2].ToString();
                            _application.textBox13.Text = foundRow.ItemArray[1].ToString();
                            _application.textBox14.Text = foundRow.ItemArray[5].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Die TeamID ist nicht gefüllt.\nBitte wenden Sie sich an den Administrator",
                            "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Bitte wählen sie eine Startnummer aus.", "Fehler", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen sie einen Wettkampf aus.", "Fehler", MessageBoxButtons.OK);
            }
        }

        public void autoSelectTeamID()
        {
            if (_application.comboBox6.Text != string.Empty && _application.comboBox6.Text != string.Empty)
            {
                fillDataSet($"Fahrer{_application.comboBox6.Text}");
                DataRow[] foundRows = ds.Tables[0].Select($"Startnummer = {_application.comboBox3.Text}");
                foreach (var foundRow in foundRows)
                {
                    if (_application.comboBox7.FindStringExact(foundRow.ItemArray[6].ToString()) != 0)
                    {
                        _application.comboBox7.SelectedIndex = _application.comboBox7.FindStringExact(foundRow.ItemArray[6].ToString());
                    }
                    else
                    {
                        MessageBox.Show(
                            $"Die TeamID '{foundRow.ItemArray[6].ToString()} Existiert nicht, bitte wählen sie eine Existierende ein oder fügen Sie eine neue TeamID hinzu.'",
                            "Fehler", MessageBoxButtons.OK);
                    }
                }

            }
            else
            {
                MessageBox.Show("Bitte wählen sie einen Wettkamf und/oder eine Startnummer aus.", "Fehler", MessageBoxButtons.OK);
            }
        }
    }
}