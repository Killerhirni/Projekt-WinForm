using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ProjektWinForm.Logik;

namespace ProjektWinForm.Manageteam
{
    public partial class ManageTeamsForm : Form
    {
        public Application.Application _application;
        private ManageTeamsFormLogic MTFL;
        private Logic lkk;
        public ManageTeamsForm(Logic lk)
        {
            lkk = lk;
            InitializeComponent();
            MTFL = new ManageTeamsFormLogic(lkk);

        }

        private void ManageTeamsForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.StartFile != "none")
            {
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                MTFL.SetProperties(sender);
                MTFL.loadCombo();
            }
            else
            {
                MessageBox.Show(
                    "Bitte wählen Sie zuerst eine Access File aus.\nDies können Sie unter dem Einstellungsbutton oben Rechts machen.",
                    "Information", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                MTFL.addTeam();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
            else if(tabControl1.SelectedIndex ==1)
            {
                MTFL.deleteTeam();
            }
            else
            {
                MTFL.saveEditedRow();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
            }
        }

        public void SetProperties(object sender)
        {
            _application = (Application.Application)sender;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox6.Text != string.Empty)
            {
                int i;
                if (!int.TryParse(textBox6.Text, out i))
                {
                    MessageBox.Show("This is a number only field");
                    textBox6.Clear();
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                textBox8.Text = "Teamname";
                button1.Text = "Add";
                button3.Visible = false;
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                textBox8.Text = "Teamname";
                button3.Visible = false;
                button1.Text = "Delete";
                MTFL.loadCombo();
            }
            else
            {
                textBox8.Text = "Teamname";
                button1.Text = "Save";
                button3.Visible = true;
                MTFL.loadCombo();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MTFL.fillTextBoxes();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != string.Empty)
            {
                int i;
                if (!int.TryParse(textBox10.Text, out i))
                {
                    MessageBox.Show("This is a number only field");
                    textBox10.Clear();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = MTFL.setBez();
            textBox8.Text = a;
        }
    }
}
