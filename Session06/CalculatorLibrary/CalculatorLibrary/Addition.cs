﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Addition
    {
        public string Add(string num1, string num2)
        {
            decimal decimal1 = Convert.ToDecimal(num1);
            decimal decimal2 = Convert.ToDecimal(num2);
            decimal AddNum = decimal1 + decimal2;
            return AddNum.ToString();
        }
    }
}
