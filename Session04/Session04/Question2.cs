using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04
{
    public class Question2
    {
        public Question2()
        {

        }
        public void PrintSum(int n)
        { 
            int count = n;
            int sum = 0;

            while (count >= 1)
            {
                sum = sum + count;
                count--; 
            }

            Console.WriteLine("The sum is " + sum);
        }
        public void PrintProduct(int n)
        {
            int mul = 1;
            
            for (int i = 1; i <= n; i++)
            {
                mul = mul * i;
            }
            Console.WriteLine("The product is " + mul);
            
        }
    }
}
