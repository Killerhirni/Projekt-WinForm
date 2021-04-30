using System.Data.OleDb;
using ProjektWinForm.Logik;

namespace ProjektWinForm.StreckenZeit
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

    public partial class ManageStreckenZeitWinForm : Form
    {
        private ProjektWinForm.Application.Application _form1Application;
        private Logic lk;
        private ManageStreckenZeitWinFormLogic MSZWL;

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
        }

        public void setProperties(ProjektWinForm.Application.Application application)
        {
            _form1Application = application;
        }
    }

    internal class ManageStreckenZeitWinFormLogic
    {
        private Logic lk;
        private ManageStreckenZeitWinForm _application;
        private ProjektWinForm.Application.Application _form1Application;
        private OleDbConnection conn;
        private OleDbDataAdapter da;
        private OleDbCommandBuilder cmd;
        private DataSet ds;

        public ManageStreckenZeitWinFormLogic(Logic lkk)
        {
            lk = lkk;
        }

        public void setProperties(ProjektWinForm.Application.Application form1Application, ManageStreckenZeitWinForm manageStreckenZeitWinForm)
        {
            _application = manageStreckenZeitWinForm;
            _form1Application = form1Application;
        }

        public void loadCombo(string text)
        {
            fillDataSet(text);
            if (_application.tabControl1.SelectedIndex.Equals(1))
            {
                _application.comboBox1.Items.Clear();
                foreach (DataRow dataRow in ds.Tables[0].Rows)
                {
                    _application.comboBox1.Items.Add(dataRow.ItemArray[2]);
                    _application.comboBox2.Items.Add(dataRow.ItemArray[1]);
                }
            }
            else if (_application.tabControl1.SelectedIndex.Equals(2))
            {
                _application.comboBox3.Items.Clear();
                _application.comboBox4.Items.Clear();
                foreach (DataRow dataRow in ds.Tables[0].Rows)
                {
                    _application.comboBox4.Items.Add(dataRow.ItemArray[2]);
                    _application.comboBox3.Items.Add(dataRow.ItemArray[1]);
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
    }
}
