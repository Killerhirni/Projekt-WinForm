using ProjektWinForm.Logik;
using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace ProjektWinForm.Manageteam
{
    internal class ManageTeamsFormLogic
    {
        private OleDbConnection conn;
        private OleDbDataAdapter da;
        private OleDbCommandBuilder cmd;
        private DataRow dr;
        private DataSet ds;
        private Manageteam.ManageTeamsForm _application;
        private Logic lk;

        public ManageTeamsFormLogic(Logic lkk)
        {
            lk = lkk;
        }

        public void addTeam()
        {
            if (_application.textBox2.Text != string.Empty && _application.textBox3.Text != string.Empty &&
                _application.textBox4.Text != string.Empty && _application.textBox5.Text != string.Empty &&
                _application.textBox6.Text != string.Empty && _application.textBox7.Text != string.Empty)
            {
                fillDataSet();
                var test = $"{_application.textBox2.Text}";
                DataRow[] drA = ds.Tables[0].Select($"Teamname = '{test}'");
                if (!drA.Any())
                {
                    addNewTeam();
                    messageBoxAdd();
                    runOut();
                }
                else
                {
                    MessageBox.Show($"Das Team mit dem Teamnamen '{_application.textBox2.Text}' existiert bereits.",
                        "Error", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("You left a Field Empty!", "Information", MessageBoxButtons.OK);
            }
        }

        private void runOut()
        {
            da.Update(ds);
            lk.UpdateAfterAdd("Team", 0);
            loadCombo();
        }

        private void messageBoxAdd()
        {
            MessageBox.Show($"Das Team wurde Eingepflegt.");
        }

        private void addNewTeam()
        {
            DataRow dr = ds.Tables[0].NewRow();
            dr["Teamname"] = _application.textBox2.Text;
            dr["Mailadresse"] = _application.textBox3.Text;
            dr["Straße"] = _application.textBox4.Text;
            dr["Hausnummer"] = _application.textBox5.Text;
            dr["Ort"] = _application.textBox7.Text;
            dr["PLZ"] = int.Parse(_application.textBox6.Text);
            ds.Tables[0].Rows.Add(dr);
        }

        private void fillDataSet()
        {
            try
            {
                conn = new OleDbConnection(
                    $"provider=Microsoft.ACE.OLEDB.12.0;Data Source = {Properties.Settings.Default.StartFile}");
                da = new OleDbDataAdapter("select * from Team", conn);
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

        public void SetProperties(object sender)
        {
            _application = (ManageTeamsForm)sender;
        }

        public void deleteTeam()
        {
            fillDataSet();
            try
            {
                if (_application.comboBox2.Text != string.Empty)
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
            DataRow[] foundRows = ds.Tables[0].Select($"TeamID = {_application.comboBox2.Text}");
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
                MessageBox.Show($"Die TeamID '{_application.comboBox2.Text}' konnte nicht gefunden werden.",
                    "Error",
                    MessageBoxButtons.OK);
            }
        }

        private void messageBoxDelete()
        {
            MessageBox.Show($"Das Team mit der TeamID '{_application.comboBox2.Text}' wurde gelöscht.");
        }

        private DialogResult deleteDialogQuestin()
        {
            DialogResult dr = MessageBox.Show(
                $"Wollen Sie das Team mit der TeamID '{_application.comboBox2.Text}' unwiederuflich Löschen?",
                "Question", MessageBoxButtons.YesNo);
            return dr;
        }

        private static void deleteRowWithFittingValue(DataRow[] foundRows)
        {
            foreach (var dataRow in foundRows)
            {
                dataRow.Delete();
            }
        }

        public void loadCombo()
        {
            fillDataSet();
            if (_application.button3.Visible != true)
            {
                _application.comboBox2.Items.Clear();
            }
            else
            {
                _application.comboBox1.Items.Clear();
            }

            foreach (DataRow dataRow in ds.Tables[0].Rows)
            {
                if (_application.button3.Visible != true)
                {
                    _application.comboBox2.Items.Add(dataRow.ItemArray[0]);
                }
                else
                {
                    _application.comboBox1.Items.Add(dataRow.ItemArray[0]);
                }
            }
        }

        public void fillTextBoxes()
        {
            if (_application.comboBox1.Text != string.Empty)
            {
                fillDataSet();
                DataRow[] foundRows = ds.Tables[0].Select($"TeamID = {_application.comboBox1.Text}");
                foreach (var foundRow in foundRows)
                {
                    _application.textBox14.Text = foundRow.ItemArray[1].ToString();
                    _application.textBox13.Text = foundRow.ItemArray[2].ToString();
                    _application.textBox12.Text = foundRow.ItemArray[3].ToString();
                    _application.textBox11.Text = foundRow.ItemArray[4].ToString();
                    _application.textBox10.Text = foundRow.ItemArray[5].ToString();
                    _application.textBox9.Text = foundRow.ItemArray[6].ToString();
                }
            }
            else
            {
                MessageBox.Show("Bitte wähen sie ein bereits existierendes Team aus.", "Fehler", MessageBoxButtons.OK);
            }
        }

        public void saveEditedRow()
        {
            fillDataSet();
            DataRow[] foundRows = ds.Tables[0].Select($"TeamID = {_application.comboBox1.Text}");
            foreach (var foundRow in foundRows)
            {
                if (_application.textBox9.Text != string.Empty && _application.textBox10.Text != string.Empty &&
                    _application.textBox11.Text != string.Empty && _application.textBox12.Text != string.Empty &&
                    _application.textBox13.Text != string.Empty && _application.textBox14.Text != string.Empty)
                {
                    fillWithNewValue(foundRow);
                    da.Update(ds.Tables[0]);
                }
                else
                {
                    MessageBox.Show("Sie haben ein Feld leer gelassen, es müssen ale felder gefüllt sein!.", "Error",
                        MessageBoxButtons.OK);
                }
            }

            messageBoxEdit();
            runOut();
        }

        private void fillWithNewValue(DataRow foundRow)
        {
            DataRow dr = foundRow;
            dr["Teamname"] = _application.textBox14.Text;
            dr["Mailadresse"] = _application.textBox13.Text;
            dr["Straße"] = _application.textBox12.Text;
            dr["Hausnummer"] = _application.textBox11.Text;
            dr["Ort"] = _application.textBox9.Text;
            dr["PLZ"] = _application.textBox10.Text;
        }

        private void messageBoxEdit()
        {
            MessageBox.Show($"Das Team mit der TeamID:{_application.comboBox1.Text} wurde erfolgreich Bearbeitet.",
                "Information", MessageBoxButtons.OK);
        }

        public string setBez()
        {
            string bez = string.Empty;
            fillDataSet();
            DataRow[] dr = new DataRow[] { };
            if (_application.tabControl1.SelectedIndex.Equals(1))
            {
                dr = ds.Tables[0].Select($"TeamID = {_application.comboBox2.Text}");
            }

            foreach (var dataRow in dr)
            {
                bez = dataRow.ItemArray[1].ToString();
            }

            return bez;


        }
    }
}