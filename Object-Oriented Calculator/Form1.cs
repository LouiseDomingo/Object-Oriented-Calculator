using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Oriented_Calculator
{
    public partial class objOrientedCalculator : Form
    {
        public objOrientedCalculator()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (displScreen.Text == "0")
            {

            }
            else
            {
                displScreen.Text = displScreen.Text + "0";
            }
        }
    }
}
