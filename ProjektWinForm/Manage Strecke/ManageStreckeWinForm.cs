using ProjektWinForm.Logik;
using System.Data.OleDb;

namespace ProjektWinForm.Manage_Strecke
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class ManageStreckeWinForm : Form
    {
        private ProjektWinForm.Application.Application _form1Application;
        private Logic lkk;
        private ManageStreckeWinFormLogic MSWL;

        public ManageStreckeWinForm(Logic logic)
        {
            InitializeComponent();
            lkk = logic;
        }

        public void setProperties(ProjektWinForm.Application.Application application)
        {
            _form1Application = application;
        }

        private void ManageStreckeWinForm_Load(object sender, EventArgs e)
        {
            MSWL = new ManageStreckeWinFormLogic(lkk);
            MSWL.setProperties(this, _form1Application);
            MSWL.loadCombo("Strecke");
            button1.Visible = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex.Equals(0))
            {
                button1.Visible = false;
                button2.Text = "Add";
            }
            else if (tabControl1.SelectedIndex.Equals(1))
            {
                button1.Visible = false;
                button2.Text = "Delete";
                MSWL.loadCombo("Strecke");
            }
            else if (tabControl1.SelectedIndex.Equals(2))
            {
                button1.Visible = true;
                button2.Text = "Save";
                MSWL.loadCombo("Strecke");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex.Equals(0))
            {
                MSWL.buttonAddClick("Strecke");
            }
            else if (tabControl1.SelectedIndex.Equals(1))
            {
                MSWL.buttonDeleteClick("Strecke");
            }
            else if (tabControl1.SelectedIndex.Equals(2))
            {
                button1.Visible = true;
                button2.Text = "Save";
                MSWL.buttonSaveClick("Strecke");
                MSWL.loadCombo("Strecke");
                textBox4.Clear();
                textBox5.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty)
            {
                int i;
                if (!int.TryParse(textBox2.Text, out i))
                {
                    MessageBox.Show("This is a number only field");
                    textBox2.Clear();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != string.Empty)
            {
                int i;
                if (!int.TryParse(textBox3.Text, out i))
                {
                    MessageBox.Show("This is a number only field");
                    textBox3.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MSWL.setValues();
        }
    }

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
            conn = new OleDbConnection(
                $"provider=Microsoft.ACE.OLEDB.12.0;Data Source = {Properties.Settings.Default.StartFile}");
            da = new OleDbDataAdapter($"select * from {text}", conn);
            cmd = new OleDbCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);

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
            lk.UpdateAfterAdd("Strecke");
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
                deleteRowWithFittingValue(foundRows);
                var dr = deleteDialogQuestin();
                if (dr == DialogResult.Yes)
                {
                    loadCombo("Strecke");
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
            foreach (DataRow dataRow in ds.Tables[0].Rows)
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

