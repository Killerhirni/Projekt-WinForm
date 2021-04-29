namespace ProjektWinForm.ManageFahrer
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

    public partial class ManageFahrerForm : Form
    {
        private ProjektWinForm.Application.Application _form1Application;
        private ManageFahrerFormLogic MFFL;

        public ManageFahrerForm()
        {
            InitializeComponent();
                MFFL= new ManageFahrerFormLogic();
        }

        public void setProperties(ProjektWinForm.Application.Application application)
        {
            _form1Application = application;
        }
    }

    public class ManageFahrerFormLogic
    {
    }
}
