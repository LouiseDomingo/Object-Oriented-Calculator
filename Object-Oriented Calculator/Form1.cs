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

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (displScreen.Text == "0")
            {
                displScreen.Text = "1";
            }
            else
            {
                displScreen.Text = displScreen.Text + "1";
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (displScreen.Text == "0")
            {
                displScreen.Text = "2";
            }
            else
            {
                displScreen.Text = displScreen.Text + "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (displScreen.Text == "0")
            {
                displScreen.Text = "3";
            }
            else
            {
                displScreen.Text = displScreen.Text + "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (displScreen.Text == "0")
            {
                displScreen.Text = "4";
            }
            else
            {
                displScreen.Text = displScreen.Text + "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (displScreen.Text == "0")
            {
                displScreen.Text = "5";
            }
            else
            {
                displScreen.Text = displScreen.Text + "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (displScreen.Text == "0")
            {
                displScreen.Text = "6";
            }
            else
            {
                displScreen.Text = displScreen.Text + "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (displScreen.Text == "0")
            {
                displScreen.Text = "7";
            }
            else
            {
                displScreen.Text = displScreen.Text + "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (displScreen.Text == "0")
            {
                displScreen.Text = "8";
            }
            else
            {
                displScreen.Text = displScreen.Text + "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (displScreen.Text == "0")
            {
                displScreen.Text = "9";
            }
            else
            {
                displScreen.Text = displScreen.Text + "9";
            }
        }
    }
}
