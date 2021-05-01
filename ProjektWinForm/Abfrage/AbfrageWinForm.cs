using System.Data.SqlClient;

namespace ProjektWinForm.Abfrage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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
            if (Properties.Settings.Default.StartFile != "none")
            {
                ABWFL.setProperties(this,_form1Application);
                ABWFL.loadConn("Wettkampf");
                ABWFL.SQLSHOW($"Fahrer{_form1Application.WettkampfID.ToString()}");
            }
            else
            {
                MessageBox.Show(
                    "Bitte wählen Sie zuerst eine Access File aus.\nDies können Sie unter dem Einstellungsbutton oben Rechts machen.",
                    "Information", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
