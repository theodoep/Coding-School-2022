using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04
{
    public class Question3
    {
        public Question3()
        {

        }
        public void PrintPrimeNumbers(int n)
        {
            bool isPrime = true;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)                    
                        isPrime = false;    
                    
                }
                if (isPrime || i == 1 || i ==2)
                    Console.WriteLine(i);
                isPrime = true;
            }
        }
    }
}
