using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class SquareRoot
    {
        public string Square(string number)
        {
            double doublenum = Convert.ToDouble(number);
            double sqrtNum = Math.Sqrt(doublenum);
            return sqrtNum.ToString();
        }

    }
}
