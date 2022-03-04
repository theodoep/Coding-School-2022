using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04
{
    public class Question1
    {
        public Question1()
        {
                
        }
        public string ReverseName(string name)
        {
            var charArray = name.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
