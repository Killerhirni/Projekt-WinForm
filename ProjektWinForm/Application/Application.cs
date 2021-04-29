using System;
using System.Drawing;
using System.Windows.Forms;
using ProjektWinForm.Logik;
using ProjektWinForm.Manageteam;
using ProjektWinForm.Properties;
using ProjektWinForm.Settings;

namespace ProjektWinForm.Application
{
    public partial class Application : Form
    {
        private Logic lk;
        private SettingsLogic se;
        private ManageTeamsForm MTF;
        private SettingsWinForm seWin;

        public Application()
        {
            InitializeComponent();
            lk = new Logic();
            se = new SettingsLogic();
            seWin = new SettingsWinForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (sender != null)
            {
                lk.SetProperties(sender);
                se.setForm1(sender);
            }

            if (!Properties.Settings.Default.StartFile.Equals("none"))
            {
                lk.Load();
            }

            if (sender == null && advanced_rbn.Checked == true)
            {
                advanced_rbn.Select();
            }
            else
            {
                regular_rbn.Select();
            }
        }
        
        private void btn_show_Click(object sender, EventArgs e)
        {
            lk.ShowTable();
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            lk.Update();
        }

        private void SearchPath_Click_1(object sender, EventArgs e)
        {
            lk.SelectPath();
        }

        private void openTable_Click_1(object sender, EventArgs e)
        {
            lk.openTable();
        }

        private void SearchFile_Click(object sender, EventArgs e)
        {
        }

        private void saveFileSettings_btn_Click(object sender, EventArgs e)
        {
        }

        private void manageTeam_btn_Click(object sender, EventArgs e)
        {
            MTF = new ManageTeamsForm(lk);
            MTF.SetProperties(this);
            MTF.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seWin.setProperties(this);
            seWin.ShowDialog();
        }
    }
}

