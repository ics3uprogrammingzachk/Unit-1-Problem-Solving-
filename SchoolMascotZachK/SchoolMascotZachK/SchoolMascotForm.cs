using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMascotZachK
{
    public partial class frmSchoolMascot : Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void SchoolMascotForm_Load(object sender, EventArgs e)
        {

        }

        private void mniMotherTeresa_Click(object sender, EventArgs e)
        {
            lblSchoolMascot.Text = "Saints";
            lblSchoolName.Text = "Mother Teresa";
        }

        private void mniImmaculata_Click_1(object sender, EventArgs e)
        {
            lblSchoolMascot.Text = "Saints";
            lblSchoolName.Text = "Immaculata";
        }

        private void mniStMark_Click(object sender, EventArgs e)
        {
            lblSchoolMascot.Text = "Saints";
            lblSchoolName.Text = "St. Mark's";
        }
    }
}
