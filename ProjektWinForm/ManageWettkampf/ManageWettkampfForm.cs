using ProjektWinForm.Logik;
using ProjektWinForm.Manage_Strecke;

namespace ProjektWinForm.ManageWettkampf
{
    using System;
    using System.Windows.Forms;

    public partial class ManageWettkampfForm : Form
    {
        private ProjektWinForm.Application.Application _form1Application;
        private ManageWettkampfFormLogic MWFL;
        private Logic lkk;
        private ManageStreckeWinForm MSWF;
        public ManageWettkampfForm(Logic lk)
        {
            InitializeComponent();
            lkk = lk;
            MWFL = new ManageWettkampfFormLogic(lkk);
        }

        public void setProperties(ProjektWinForm.Application.Application application)
        {
            _form1Application = application;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           var a = MWFL.setBez();
           textBox4.Text = a;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex.Equals(0))
            {
                textBox5.Text = "Bezeichnung des Wettkampfes";
                textBox4.Text = "Bezeichnung des Wettkampfes";
                button3.Visible = false;
                button1.Text = "Add";
                MWFL.loadCombo("Strecke");
            }
            else if (tabControl1.SelectedIndex.Equals(1))
            {
                textBox4.Text = "Bezeichnung des Wettkampfes";
                button1.Text = "Delete";
                button3.Visible = false;
                MWFL.loadCombo("Wettkampf");
            }
            else if (tabControl1.SelectedIndex.Equals(2))
            {
                textBox5.Text = "Bezeichnung des Wettkampfes";
                button1.Text = "Save";
                button3.Visible = true;
                MWFL.loadCombo("Wettkampf");
                MWFL.loadCombo("Strecke");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageWettkampfForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.StartFile != "none")
            {
                button3.Visible = false;
                MWFL.setProperties(sender);
                MWFL.loadCombo("Strecke");
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "MM/dd/yyyy";
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
            if (tabControl1.SelectedIndex.Equals(0))
            {
                MWFL.addWettkampf();
            }
            else if (tabControl1.SelectedIndex.Equals(1))
            {
                MWFL.deleteWettkampf();
            }
            else if (tabControl1.SelectedIndex.Equals(2))
            {
                MWFL.saveEdit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MWFL.editWettkampf();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MSWF = new ManageStreckeWinForm(lkk);
            MSWF.ShowDialog();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = MWFL.setBez();
            textBox5.Text = a;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MSWF = new ManageStreckeWinForm(lkk);
            MSWF.ShowDialog();
        }
    }
}
