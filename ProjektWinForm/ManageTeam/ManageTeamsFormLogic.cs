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
        private Application.Application _form1Application;
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
                addNewTeam();
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
            lk.UpdateAfterAddTeam();
            _application.Close();
        }

        private void messageBoxAdd()
        {
            MessageBox.Show($"Das Team mit der TeamID: '{_application.textBox8.Text}' wurde Eingepflegt.");
        }

        private void addNewTeam()
        {
            DataRow dr = ds.Tables[0].NewRow();
            dr["Teamname"] = _application.textBox2.Text;
            dr["Mailadresse"] = _application.textBox3.Text;
            dr["Straße"] = _application.textBox4.Text;
            dr["Hausnummer"] = _application.textBox5.Text;
            dr["Ort"] = _application.textBox7.Text;
            dr["PLZ"] = _application.textBox6.Text;
            ds.Tables[0].Rows.Add(dr);
        }

        private void fillDataSet()
        {
            conn = new OleDbConnection(
                $"provider=Microsoft.ACE.OLEDB.12.0;Data Source = {Properties.Settings.Default.StartFile}");
            da = new OleDbDataAdapter("select * from Team", conn);
            cmd = new OleDbCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
        }

        public void SetProperties(object sender, Application.Application form1Application)
        {
            _application = (ManageTeamsForm)sender;
            form1Application = _form1Application;
        }

        public void deleteTeam()
        {
            fillDataSet();
            try
            {
                if (_application.textBox8.Text != string.Empty)
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
            DataRow[] foundRows = ds.Tables[0].Select($"TeamID = {_application.textBox8.Text}");
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
                MessageBox.Show($"Die TeamID '{_application.textBox8.Text}' konnte nicht gefunden werden.",
                    "Error",
                    MessageBoxButtons.OK);
            }
        }

        private void messageBoxDelete()
        {
            MessageBox.Show($"Das Team mit der TeamID '{_application.textBox8.Text}' wurde gelöscht.");
        }

        private DialogResult deleteDialogQuestin()
        {
            DialogResult dr = MessageBox.Show(
                $"Wollen Sie das Team mit der TeamID '{_application.textBox8.Text}' unwiederuflich Löschen?",
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
            _application.comboBox1.Items.Clear();
            foreach (DataRow dataRow in ds.Tables[0].Rows)
            {
                _application.comboBox1.Items.Add(dataRow.ItemArray[0]);
            }
        }

        // public void filterForCombo()
        // {
        //     fillDataSet();
        //     _application.comboBox1.Items.Remove();
        //     DataRow[] foundRows = ds.Tables[0].Select($"TeamID = {_application.comboBox1.Text}");
        //     foreach (var foundRow in foundRows)
        //     {
        //         _application.comboBox1.Items.Add(foundRow.ItemArray[0]);
        //     }
        // }
        public void fillTextBoxes()
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

        public void saveEditedRow()
        {
            fillDataSet();
            DataRow[] foundRows = ds.Tables[0].Select($"TeamID = {_application.comboBox1.Text}");
            foreach (var foundRow in foundRows)
            {
                foundRow.ItemArray.SetValue(_application.textBox14.Text,1);
                foundRow.ItemArray[2] = _application.textBox13.Text;
                foundRow.ItemArray[3] = _application.textBox12.Text;
                foundRow.ItemArray[4] = _application.textBox11.Text;
                foundRow.ItemArray[5] = _application.textBox10.Text;
                foundRow.ItemArray[6] = _application.textBox9.Text;
                da.Update(ds.Tables[0]);
            }

            messageBoxEdit();
            runOut();
        }

        private void messageBoxEdit()
        {
            MessageBox.Show($"Das Team mit der TeamID:{_application.comboBox1.Text} wurde erfolgreich Bearbeitet.",
                "Information", MessageBoxButtons.OK);
        }
    }
}