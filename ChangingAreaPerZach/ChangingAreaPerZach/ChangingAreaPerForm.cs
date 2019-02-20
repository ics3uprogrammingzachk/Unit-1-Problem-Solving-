using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangingAreaPerZach
{
    public partial class frmChangingAreaPer : Form
    {
        public frmChangingAreaPer()
        {
            InitializeComponent();
        }

        private void txtLegthInput_TextChanged(object sender, EventArgs e)
        {
            double Legth = Convert.ToDouble(txtLegthInput);
            
            //double lblPermeter
        }
    }
}
