using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Power
    {
     
        public string RaiseToPower(string num1, string num2)
        {
            double doublenum1 = Convert.ToDouble(num1);
            double doublenum2 = Convert.ToDouble(num2);
            double PowNum = Math.Pow(doublenum1,doublenum2);
            return PowNum.ToString();
        }
    }
}
