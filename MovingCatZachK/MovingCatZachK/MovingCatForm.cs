/*
 * Created by: Zachary Kranabetter
 * Created on: Febuary 14th 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Name of Program
 * This program has a menu strip with menu items each referring to a different picture. When I click on the item the picture box changes to the corresponding images
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

namespace MovingCatZachK
{
    public partial class MovingCatFrm : Form
    {
        public MovingCatFrm()
        {
            InitializeComponent();
        }

        private void MovingCatForm_Load(object sender, EventArgs e)
        {

        }

        //Changes the cats picture
        private void mniCat1_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat1;
        }

        private void mniCat2_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat2;
        }
    }
}
