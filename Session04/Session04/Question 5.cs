using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04
{
    public class Question5
    {
        public Question5()
        {

        }
        public int[] Array5 = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

        public void SortArray()
        {
            for (int j = 0; j <= Array5.Length - 2; j++)
            {
                for (int i = 0; i <= Array5.Length - 2; i++)
                {
                    if (Array5[i] > Array5[i + 1])
                    {
                        var temp = Array5[i + 1];
                        Array5[i + 1] = Array5[i];
                        Array5[i] = temp;
                    }
                }
            }
        }

        public void PrintArray()
        {
            for (int j = 0; j < Array5.Length; j++)
            {
                Console.WriteLine(Array5[j]);
            }
        }
    }
}

