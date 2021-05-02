using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using ProjektWinForm.Logik;

namespace ProjektWinForm.Manage_Strecke
{
    internal class ManageStreckeWinFormLogic
    {
        private ManageStreckeWinForm _application;
        private ProjektWinForm.Application.Application _form1application;
        private Logic lk;
        private OleDbConnection conn;
        private OleDbDataAdapter da;
        private OleDbCommandBuilder cmd;
        private DataSet ds;

        public ManageStreckeWinFormLogic(Logic lkk)
        {
            lk = lkk;
        }

        public void setProperties(ManageStreckeWinForm manageStreckeWinForm, ProjektWinForm.Application.Application form1Application)
        {
            _application = manageStreckeWinForm;
            _form1application = form1Application;
        }

        public void loadCombo(string text)
        {
            fillDataSet(text);
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
                _application.comboBox2.Items.Clear();
                foreach (DataRow dataRow in ds.Tables[0].Rows)
                {
                    _application.comboBox2.Items.Add(dataRow.ItemArray[0]);
                }
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
            }

        }

        public void buttonAddClick(string text)
        {
            if (_application.textBox2.Text != string.Empty && _application.textBox3.Text != string.Empty)
            {
                fillDataSet(text);
                addNewStrecke();
                _application.textBox4.Clear();
                _application.textBox5.Clear();
                messageBoxAdd();
                runOut();
            }
            else
            {
                MessageBox.Show("Bitte füllen sie alle Felder aus.", "Error", MessageBoxButtons.OK);
            }
        }

        private void messageBoxAdd()
        {
            MessageBox.Show($"Die Strecke wurde Eingepflegt.");
        }

        private void runOut()
        {
            da.Update(ds);
            lk.UpdateAfterAdd("Strecke", 0);
            loadCombo("Strecke");
        }

        private void addNewStrecke()
        {
            DataRow dr = ds.Tables[0].NewRow();
            dr["Laenge"] = int.Parse(_application.textBox2.Text);
            dr["Höhenmeter"] = int.Parse(_application.textBox3.Text);
            ds.Tables[0].Rows.Add(dr);
        }

        public void buttonDeleteClick(string text)
        {
            fillDataSet(text);
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
            var text = "Strecke";
            fillDataSet(text);
            DataRow[] foundRows = ds.Tables[0].Select($"StreckeID = {int.Parse(_application.comboBox1.Text)}");
            if (foundRows.Any())
            {
                var dr = deleteDialogQuestin();
                if (dr == DialogResult.Yes)
                {
                    deleteRowWithFittingValue(foundRows);
                    runOut();
                    loadCombo("Strecke");
                    messageBoxDelete();
                }
                else
                {
                    MessageBox.Show("Der vorgang wurde abgebrochen", "Abbruch", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show($"Die TeamID '{_application.comboBox1.Text}' konnte nicht gefunden werden.",
                    "Error",
                    MessageBoxButtons.OK);
            }

        }

        private void messageBoxDelete()
        {
            MessageBox.Show($"Die Strecke wurde gelöscht.");
        }

        private DialogResult deleteDialogQuestin()
        {
            DialogResult dr = MessageBox.Show(
                $"Wollen Sie die Strecke mit der StreckenID '{_application.comboBox1.Text}' unwiederuflich Löschen?",
                "Question", MessageBoxButtons.YesNo);
            return dr;

        }

        private void deleteRowWithFittingValue(DataRow[] foundRows)
        {
            foreach (DataRow dataRow in foundRows)
            {
                dataRow.Delete();
            }
        }

        public void setValues()
        {
            if (_application.comboBox2.Text != string.Empty)
            {
                var text = "Strecke";
                fillDataSet(text);
                DataRow[] foundRows = ds.Tables[0].Select($"StreckeID = {_application.comboBox2.Text}");
                foreach (var foundRow in foundRows)
                {
                    _application.textBox4.Text = foundRow.ItemArray[1].ToString();
                    _application.textBox5.Text = foundRow.ItemArray[2].ToString();
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Strecke aus.", "Error", MessageBoxButtons.OK);
            }
        }

        public void buttonSaveClick(string text)
        {
            if (_application.comboBox2.Text != string.Empty && _application.textBox4.Text != string.Empty &&
                _application.textBox5.Text != string.Empty)
            {
                fillDataSet(text);
                DataRow[] foundRows = ds.Tables[0].Select($"StreckeID = {int.Parse(_application.comboBox2.Text)}");

                foreach (var foundRow in foundRows)
                {
                    fillWithNewValue(foundRow);
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
            MessageBox.Show($"Die Strecke mit der StreckenID:{_application.comboBox2.Text} wurde erfolgreich Bearbeitet.",
                "Information", MessageBoxButtons.OK);
        }

        private void fillWithNewValue(DataRow foundRow)
        {
            DataRow dr = foundRow;
            dr["Laenge"] = int.Parse(_application.textBox4.Text);
            dr["Höhenmeter"] = int.Parse(_application.textBox5.Text);
        }
    }
}