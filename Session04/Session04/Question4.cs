using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04
{
    public class Question4
    {
        public Question4()
        {

        }
        public int[] Array1 = { 2, 4, 9, 12};
        public int[] Array2 = { 1, 3, 7, 10};
        public int[] NewArray = new int [16];
        
        public void PrintNewArray()
        {
            for (int i = 0; i < Array1.Length; i++)
            {
                for (int j = 0; j < Array2.Length; j++)
                {
                    NewArray[i+j*Array1.Length] = Array1[i] * Array2[j];
                    Console.Write(NewArray[i + j * Array1.Length]+" ");
                }

                Console.WriteLine();
            }
        } 
        

    }
}
