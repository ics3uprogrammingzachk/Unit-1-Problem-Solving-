/*
 * Created by: Zachary Kranabetter
 * Created on: Febuary 14th 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - School Mascot
 * This a program that displays a menu strip with menu items corresponding to different schools. When I click on each menu item, the school label and mascot changes accordingly. 
*/

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

        // Change the name and mascot to the school
        private void mniMotherTeresa_Click(object sender, EventArgs e)
        {
            lblSchoolMascot.Text = "Spartans";
            lblSchoolName.Text = "Mother Teresa";
        }

        private void mniImmaculata_Click_1(object sender, EventArgs e)
        {
            lblSchoolMascot.Text = "Saints";
            lblSchoolName.Text = "Immaculata";
        }

        private void mniStMark_Click(object sender, EventArgs e)
        {
            lblSchoolMascot.Text = "Warriors";
            lblSchoolName.Text = "St. Mark's";
        }
    }
}
