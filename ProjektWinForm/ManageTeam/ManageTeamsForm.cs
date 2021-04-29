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
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            MTFL.SetProperties(sender, _application);
            MTFL.loadCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                MTFL.addTeam();
            }
            else if(tabControl1.SelectedIndex ==1)
            {
                MTFL.deleteTeam();
            }
            else
            {
                MTFL.saveEditedRow();
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
                button1.Text = "Add";
                button3.Visible = false;
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                button3.Visible = false;
                button1.Text = "Delete";
                MTFL.loadCombo();
            }
            else
            {
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
    }
}
