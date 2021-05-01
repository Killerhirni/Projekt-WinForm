using System.Data.OleDb;

namespace ProjektWinForm.ShowResults
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    public partial class AskForWettkampf : Form
    {
        private ProjektWinForm.Application.Application _form1Application;
        private AskForWettkampfLogik AFWL;

        public AskForWettkampf()
        {
            InitializeComponent();
            AFWL = new AskForWettkampfLogik();
        }

        public void setProperties(ProjektWinForm.Application.Application application)
        {
            _form1Application = application;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AskForWettkampf_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.StartFile != "none")
            {

                AFWL.setProperties(this, _form1Application);
                AFWL.loadCombo("Wettkampf");
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
            AFWL.setWettkampfID();
            this.Close();
        }
    }

    internal class AskForWettkampfLogik
    {
        private AskForWettkampf _application;
        private OleDbConnection conn;
        private OleDbDataAdapter da;
        private OleDbCommandBuilder cmd;
        private DataSet ds;
        private ProjektWinForm.Application.Application _form1Application;

        public void loadCombo(string text)
        {
            fillDataSet(text);
            if (text != "Wettkampf")
            {
            }
            else
            {
                _application.comboBox1.Items.Clear();
                foreach (DataRow dataRow in ds.Tables[0].Rows)
                {
                    _application.comboBox1.Items.Add(dataRow.ItemArray[0]);
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

        public void setProperties(AskForWettkampf askForWettkampf,
            ProjektWinForm.Application.Application form1Application)
        {
            _application = askForWettkampf;
            _form1Application = form1Application;
        }

        public void setWettkampfID()
        {

            if (_application.comboBox1.Text != string.Empty)
            {
                _form1Application.WettkampfID = int.Parse(_application.comboBox1.Text);
            }
            else
            {
                MessageBox.Show("Bitte wählen sie eine WettkampfID aus.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
