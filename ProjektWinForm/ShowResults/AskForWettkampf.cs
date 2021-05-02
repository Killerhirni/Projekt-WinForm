namespace ProjektWinForm.ShowResults
{
    using System;
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
}
