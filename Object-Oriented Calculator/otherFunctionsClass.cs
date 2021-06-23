using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Calculator
{
    class otherFunctionsClass
    {
        public String input;
        public String result2;

        public void Percent()
        {
            result2 = (Double.Parse(input) / 100).ToString();
        }

        public void Squared()
        {
            result2 = Math.Pow(Double.Parse(input), 2).ToString();
        }

        public void SquareRoot()
        {
            result2 = Math.Sqrt(Double.Parse(input)).ToString();
        }
    }
}
