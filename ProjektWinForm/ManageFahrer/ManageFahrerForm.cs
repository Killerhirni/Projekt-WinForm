using System.Data;
using ProjektWinForm.Logik;
using ProjektWinForm.Manageteam;
using ProjektWinForm.ManageWettkampf;

namespace ProjektWinForm.ManageFahrer
{
    using System;
    using System.Windows.Forms;

    public partial class ManageFahrerForm : Form
    {
        private ProjektWinForm.Application.Application _form1Application;
        private ManageFahrerFormLogic MFFL;
        private Logic lk;

        public ManageFahrerForm(Logic lk)
        {
            InitializeComponent();
            MFFL = new ManageFahrerFormLogic(lk);
        }

        public void setProperties(ProjektWinForm.Application.Application application)
        {
            _form1Application = application;
        }

        private void ManageFahrerForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.StartFile != "none")
            {
                MFFL.setProperties(this);
                MFFL.loadCombo("Team");
                MFFL.loadCombo("Wettkampf");
                button3.Visible = false;
            }
            else
            {
                MessageBox.Show(
                    "Bitte wählen Sie zuerst eine Access File aus.\nDies können Sie unter dem Einstellungsbutton oben Rechts machen.",
                    "Information", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                textBox7.Text = "Bezeichnung des Wettkampfs";
                button1.Text = "Add";
                textBox19.Text = "Name des Fahrers";
                button3.Visible = false;
                comboBox1.Items.Clear();
                MFFL.loadCombo("Team");
                MFFL.loadCombo("Wettkampf");
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                textBox8.Text = "Bezeichnung des Wettkampfs";
                button3.Visible = false;
                textBox19.Text = "Name des Fahrers";
                button1.Text = "Delete";
                comboBox2.Items.Clear();
                MFFL.loadCombo("Wettkampf");
            }
            else
            {
                textBox19.Text = "Name des Fahrers";
                textBox9.Text = "Bezeichnung des Wettkampfs";
                button1.Text = "Save";
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
                MFFL.addFahrerToWettkampf();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                MFFL.deleteFahrer();
            }
            else
            {
                MFFL.saveEditedRow();
                textBox14.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox16.Clear();
                textBox15.Clear();
                comboBox7.Items.Clear();
                comboBox3.Items.Clear();
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
            MFFL.loadCombo($"Teilnahme");
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = MFFL.setBez();
            textBox9.Text = a;
            MFFL.loadCombo($"Teilnahme");
            MFFL.loadCombo("Team");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MFFL.fillTextBoxes();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            MFFL.autoSelectTeamID();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Manageteam.ManageTeamsForm addTeamForm = new ManageTeamsForm(lk = new Logic());
            addTeamForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageWettkampfForm MWF = new ManageWettkampfForm(lk);
            MWF.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = MFFL.setBezS();
            textBox19.Text = a;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text != string.Empty)
            {
                int i;
                if (!int.TryParse(textBox14.Text, out i))
                {
                    MessageBox.Show("This is a number only field");
                    textBox14.Clear();
                }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != string.Empty)
            {
                int i;
                if (!int.TryParse(textBox11.Text, out i))
                {
                    MessageBox.Show("This is a number only field");
                    textBox11.Clear();
                }
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
