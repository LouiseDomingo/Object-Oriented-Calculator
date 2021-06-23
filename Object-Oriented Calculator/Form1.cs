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
        operationsClass operation = new operationsClass();
        otherFunctionsClass otherFunctions = new otherFunctionsClass();

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

        //other buttons in the form
        
        Double negativeVal;
        private void posiNegativeBtn_Click(object sender, EventArgs e)
        {
            if (displScreen.Text != "0")
            {
                negativeVal = Convert.ToDouble(displScreen.Text) * -1;
                displScreen.Text = negativeVal.ToString();
            }
            else
            {

            }
        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            if (displScreen.Text.Contains("."))
            {

            }
            else
            {
                displScreen.Text = displScreen.Text + ".";
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (displScreen.Text.Length > 1)
            {
                displScreen.Text = displScreen.Text.Remove(displScreen.Text.Length - 1);
            }
            else
            {
                displScreen.Text = "0";
            }
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            displScreen.Text = "0";
        }

        //for operations
        private void additionBtn_Click(object sender, EventArgs e)
        {
            equalsBtn.Enabled = true;
            operation.firstNum = displScreen.Text;
            displScreen.Text = "0";
            operation.operand = "+";
            operation.operationIsPressed = true;
        }

        private void subtractionBtn_Click(object sender, EventArgs e)
        {
            equalsBtn.Enabled = true;
            operation.firstNum = displScreen.Text;
            displScreen.Text = "0";
            operation.operand = "-";
            operation.operationIsPressed = true;
        }

        private void multiplicationBtn_Click(object sender, EventArgs e)
        {
            equalsBtn.Enabled = true;
            operation.firstNum = displScreen.Text;
            displScreen.Text = "0";
            operation.operand = "*";
            operation.operationIsPressed = true;
        }

        private void divisionBtn_Click(object sender, EventArgs e)
        {
            equalsBtn.Enabled = true;
            operation.firstNum = displScreen.Text;
            displScreen.Text = "0";
            operation.operand = "/";
            operation.operationIsPressed = true;
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            if (operation.operand == "+")
            {
                operation.secondNum = displScreen.Text;
                operation.Add();
                displScreen.Text = operation.result;
            }

            if (operation.operand == "-")
            {
                operation.secondNum = displScreen.Text;
                operation.Subtract();
                displScreen.Text = operation.result;
            }

            if (operation.operand == "*")
            {
                operation.secondNum = displScreen.Text;
                operation.Multiply();
                displScreen.Text = operation.result;
            }

            if (operation.operand == "/")
            {
                operation.secondNum = displScreen.Text;
                operation.Divide();
                displScreen.Text = operation.result;
                equalsBtn.Enabled = false;
            }
        }

        //for other functions of the calculator
        private void percentBtn_Click(object sender, EventArgs e)
        {
            otherFunctions.input = displScreen.Text;
            otherFunctions.Percent();
            displScreen.Text = otherFunctions.result2;
        }

        private void squaredBtn_Click(object sender, EventArgs e)
        {
            otherFunctions.input = displScreen.Text;
            otherFunctions.Squared();
            displScreen.Text = otherFunctions.result2;
        }

        private void sqrRootBtn_Click(object sender, EventArgs e)
        {
            otherFunctions.input = displScreen.Text;
            otherFunctions.SquareRoot();
            displScreen.Text = otherFunctions.result2;
        }

        private void fractionBtn_Click(object sender, EventArgs e)
        {
            otherFunctions.input = displScreen.Text;
            otherFunctions.Fraction();
            displScreen.Text = otherFunctions.result2;
        }
    }
}
