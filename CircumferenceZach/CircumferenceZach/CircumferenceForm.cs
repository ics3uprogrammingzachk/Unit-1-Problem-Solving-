/*
 * Created by: Zachary Kranabetter
 * Created on: Febuary 20th 2019 (Connor's Birthday)
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Top-Down Design & Flow Charts
 * This program calculates the circumference of a circle with a given radius
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

namespace CircumferenceZach
{
    public partial class frmCircumference : Form
    {
        public frmCircumference()
        {
            InitializeComponent();
        }

        const double PI = Math.PI;

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {
            lblAnswer.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txtRadius.Text); 

            double circumference = PI * radius * 2;

            lblAnswer.Text = Convert.ToString("The circumference is" + circumference);

            lblAnswer.Visible = true;
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {

        }


    }
}
