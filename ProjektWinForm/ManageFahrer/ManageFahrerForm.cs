using System.Data.OleDb;
using ProjektWinForm.Logik;
using ProjektWinForm.Manageteam;

namespace ProjektWinForm.ManageFahrer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class ManageFahrerForm : Form
    {
        private ProjektWinForm.Application.Application _form1Application;
        private ManageFahrerFormLogic MFFL;
        private Logic lk;

        public ManageFahrerForm(Logic lk)
        {
            InitializeComponent();
                MFFL= new ManageFahrerFormLogic(lk);
        }

        public void setProperties(ProjektWinForm.Application.Application application)
        {
            _form1Application = application;
        }

        private void ManageFahrerForm_Load(object sender, EventArgs e)
        {
            MFFL.setProperties(this);
            MFFL.loadCombo("Team");
            MFFL.loadCombo("Wettkampf");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                textBox7.Text = "Bezeichnung des Wettkampfs";
                button1.Text = "Add";
                button3.Visible = false;
                button4.Visible = true;
                button5.Visible = true;
                comboBox1.Items.Clear();
                MFFL.loadCombo("Team");
                MFFL.loadCombo("Wettkampf");
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                textBox8.Text = "Bezeichnung des Wettkampfs";
                button3.Visible = false;
                button5.Visible = false;
                button4.Visible = false;
                button1.Text = "Delete";
                comboBox2.Items.Clear();
                MFFL.loadCombo("Wettkampf");
            }
            else
            {
                textBox9.Text = "Bezeichnung des Wettkampfs";
                button1.Text = "Save";
                button4.Visible = false;
                button5.Visible = false;
                button3.Visible = true;
                comboBox3.Items.Clear();
                MFFL.loadCombo("Wettkampf");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                MFFL.addTeam();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                MFFL.deleteTeam();
            }
            else
            {
                MFFL.saveEditedRow();
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != string.Empty)
            {
                int i;
                if (!int.TryParse(textBox5.Text, out i))
                {
                    MessageBox.Show("This is a number only field");
                    textBox5.Clear();
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = MFFL.setBez();
            textBox7.Text = a;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Manageteam.ManageTeamsForm addTeamForm = new ManageTeamsForm(lk = new Logic());
            addTeamForm.ShowDialog();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = MFFL.setBez();
            textBox8.Text = a;
            MFFL.loadCombo($"Fahrer{comboBox5.Text}");
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = MFFL.setBez();
            textBox9.Text = a;
            MFFL.loadCombo($"Fahrer{comboBox6.Text}");
        }
    }

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
                if (_application.tabControl1.SelectedIndex.Equals(1))
                {
                    _application.comboBox2.Items.Clear();
                }
                else if (_application.tabControl1.SelectedIndex.Equals(0))
                {
                    _application.comboBox1.Items.Clear();
                }else if(_application.tabControl1.SelectedIndex.Equals(2))
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
            else if (_application.tabControl1.SelectedIndex.Equals(0))
            {
                _application.comboBox4.Items.Clear();
                foreach (DataRow dataRow in ds.Tables[0].Rows)
                {
                    _application.comboBox4.Items.Add(dataRow.ItemArray[0]);
                }
            }else if (_application.tabControl1.SelectedIndex.Equals(1))
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

        private void fillDataSet(string text)
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

        public void addTeam()
        {
            if (_application.comboBox4.Text != string.Empty &&_application.comboBox1.Text != string.Empty&&_application.textBox2.Text != string.Empty && _application.textBox3.Text != string.Empty &&
                _application.textBox4.Text != string.Empty && _application.textBox5.Text != string.Empty &&
                _application.textBox6.Text != string.Empty )
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
            lk.UpdateAfterAdd($"Fahrer{_application.comboBox4.Text}");
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

        public void deleteTeam()
        {
            
        }

        public void saveEditedRow()
        {
            
        }

        public string setBez()
        {
            string bez = string.Empty;
            fillDataSet("Wettkampf");
            var dr = ds.Tables[0].Select($"WettkampfID = {int.Parse(_application.comboBox4.Text)}");
            foreach (var dataRow in dr)
            {
                bez = dataRow.ItemArray[2].ToString();
            }

            return bez;
        }
    }
}
