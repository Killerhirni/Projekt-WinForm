using ProjektWinForm.Logik;

namespace ProjektWinForm.Manage_Strecke
{
    using System;
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
            if (Properties.Settings.Default.StartFile != "none")
            {
                MSWL = new ManageStreckeWinFormLogic(lkk);
                MSWL.setProperties(this, _form1Application);
                MSWL.loadCombo("Strecke");
                button1.Visible = false;
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
}

