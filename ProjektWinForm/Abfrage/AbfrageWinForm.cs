using System.Data.OleDb;

namespace ProjektWinForm.Abfrage
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

    public partial class AbfrageWinForm : Form
    {
        private ProjektWinForm.Application.Application _form1Application;
        private AbfrageWinFormLogik ABWFL;

        public AbfrageWinForm()
        {
            InitializeComponent();
            ABWFL = new AbfrageWinFormLogik();

        }

        public void setProperties(ProjektWinForm.Application.Application application)
        {
            _form1Application = application;
        }

        private void AbfrageWinForm_Load(object sender, EventArgs e)
        {
            ABWFL.setProperties(this,_form1Application);
            ABWFL.loadConn("Wettkampf");
            // ABWFL.SQLSHOW();
        }
    }

    internal class AbfrageWinFormLogik
    {
        private OleDbConnection conn;
        private OleDbDataAdapter da;
        private OleDbCommandBuilder cmd;
        private OleDbCommand cmdd;
        private DataSet ds;
        private ProjektWinForm.Application.Application _form1Application;
        private AbfrageWinForm _application;
        private BindingSource bs;

        public void loadConn(string text)
        {
            conn = new OleDbConnection(
                $"provider=Microsoft.ACE.OLEDB.12.0;Data Source = {Properties.Settings.Default.StartFile}");
            da = new OleDbDataAdapter($"select * from {text}", conn);
            cmd = new OleDbCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);

        }

        public void setProperties(AbfrageWinForm abfrageWinForm, ProjektWinForm.Application.Application form1Application)
        {
            _application = abfrageWinForm;
            _form1Application = form1Application;
        }

        /*public void SQLSHOW()
        {
            da = new OleDbDataAdapter(
                $"SELECT Teilnahme.Startnummer, Fahrer.Vorname, Fahrer.Nachname, Team.TeamID, Team.Teamname, Teilnahme.Streckenzeit, Wettkampf.Bezeichnung, Teilnahme.Platzierung FROM Wettkampf INNER JOIN" +
                $" (Team INNER JOIN (Fahrer INNER JOIN Teilnahme ON Fahrer.Startnummer = Teilnahme.Startnummer) ON Team.TeamID = Fahrer.TeamID) ON W" +
                $"ettkampf.WettkampfID = {_form1Application.WettkampfID}", conn);
            cmd = new OleDbCommandBuilder(da);
            ds = new DataSet();
            bs = new BindingSource();
            da.Fill(ds);
            _application.dataGridView1.DataSource = ds.Tables[0];
        }*/
    }
}
