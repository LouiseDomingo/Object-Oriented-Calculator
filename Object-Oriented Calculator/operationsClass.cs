using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Calculator
{
    class operationsClass
    {
        public String firstNum = "";
        public String secondNum = "";
        public String result = "";
        public Boolean operationIsPressed = false;
        public String operand = "";

        public void Add()
        {
            result = (Double.Parse(firstNum) + Double.Parse(secondNum)).ToString();
        }
    }
}
