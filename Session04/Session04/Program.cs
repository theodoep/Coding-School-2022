using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question1 Q1 = new Question1();
            Console.WriteLine(Q1.ReverseName("Theodore Papazoglou"));

            Console.WriteLine("Type any number:  ");
            int n = Int32.Parse(Console.ReadLine());
            Question2 Q2 = new Question2();
            Q2.PrintSum(n);
            Q2.PrintProduct(n);

            n = Int32.Parse(Console.ReadLine());
            Question3 Q3 = new Question3();
            Q3.PrintPrimeNumbers(n);

            Question4 Q4 = new Question4();
            Q4.PrintNewArray();

            Question5 Q5 = new Question5();
            Q5.SortArray();
            Q5.PrintArray();

            Console.ReadLine();

        }
    }
}
