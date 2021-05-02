using ProjektWinForm.Logik;
using ProjektWinForm.ManageFahrer;
using ProjektWinForm.ManageWettkampf;

namespace ProjektWinForm.StreckenZeit
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class ManageStreckenZeitWinForm : Form
    {
        private ProjektWinForm.Application.Application _form1Application;
        private Logic lk;
        private ManageStreckenZeitWinFormLogic MSZWL;
        private ManageWettkampfForm MWF;
        private ManageFahrerForm MFF;

        public ManageStreckenZeitWinForm(Logic logic)
        {
            InitializeComponent();
            lk = logic;
            MSZWL = new ManageStreckenZeitWinFormLogic(lk);
        }

        private void ManageStreckenZeitWinForm_Load(object sender, EventArgs e)
        {
            MSZWL.setProperties(_form1Application, this);
            MSZWL.loadCombo("Teilnahme");
            button1.Visible = false;
        }

        public void setProperties(ProjektWinForm.Application.Application application)
        {
            _form1Application = application;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex.Equals(0))
            {
                MSZWL.AddTime();
            }
            else if (tabControl1.SelectedIndex.Equals(1))

            {
                MSZWL.editTime();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            var a = MSZWL.setBez();
            textBox2.Text = a;
            MSZWL.loadComboStartnummer("Teilnahme");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex.Equals(0))
            {
                MSZWL.loadCombo("Teilnahme");
                textBox2.Text = "Bezeichnung des Wettkampfes";
            }
            else if(tabControl1.SelectedIndex.Equals(1))
            {
                button1.Visible = true;
                button2.Text = "Save";
                textBox3.Text = "Bezeichnung des Wettkampfes";
                MSZWL.loadCombo("Teilnahme");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MSZWL.showTime();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            var a = MSZWL.setBez();
            textBox3.Text = a;
            MSZWL.loadComboStartnummer("Teilnahme");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MWF = new ManageWettkampfForm(lk);
            MWF.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MFF = new ManageFahrerForm(lk);
            MFF.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MWF = new ManageWettkampfForm(lk);
            MWF.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MFF = new ManageFahrerForm(lk);
            MFF.ShowDialog();
        }
    }
}
