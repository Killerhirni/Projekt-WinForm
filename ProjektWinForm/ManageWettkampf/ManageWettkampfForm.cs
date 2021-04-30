using System.Data.OleDb;

namespace ProjektWinForm.ManageWettkampf
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

    public partial class ManageWettkampfForm : Form
    {
        private ProjektWinForm.Application.Application _form1Application;
        private ManageWettkampfFormLogic MWFL;
        public ManageWettkampfForm()
        {
            InitializeComponent();
            MWFL = new ManageWettkampfFormLogic();
        }

        public void setProperties(ProjektWinForm.Application.Application application)
        {
            _form1Application = application;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex.Equals(0))
            {
                MWFL.loadCombo("Strecke");
            }
            else if (tabControl1.SelectedIndex.Equals(1))
            {
                
            }
            else if (tabControl1.SelectedIndex.Equals(2))
            {
                
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
            button3.Visible = false;
            MWFL.setProperties(sender);
        }
    }

    internal class ManageWettkampfFormLogic
    {
        private ManageWettkampfForm _application;
        private OleDbConnection conn;
        private OleDbDataAdapter da;
        private OleDbCommandBuilder cmd;
        private DataSet ds;

        public void loadCombo(string text)
        {
            fillDataSet(text);
            if (text != "Strecke")
            {
                if (text != "Wettkampf")
                {
                    MessageBox.Show("PUFF!!", "PUFFFF", MessageBoxButtons.OK);
                }
                else
                {
                    if (_application.tabControl1.SelectedIndex.Equals(0))
                    {
                        _application.comboBox1.Items.Clear();
                        _application.textBox1.Clear();
                    }
                    else if (_application.tabControl1.SelectedIndex.Equals(1))
                    {
                        _application.comboBox2.Items.Clear();
                    }
                    else if (_application.tabControl1.SelectedIndex.Equals(2))
                    {
                        _application.comboBox3.Items.Clear();
                        _application.comboBox4.Items.Clear();
                        _application.textBox2.Clear();
                    }

                    foreach (var dataRow in ds.Tables[0].Rows)
                    {

                    }
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

        public void setProperties(object sender)
        {
            _application = (ManageWettkampfForm)sender;
        }
    }
}
