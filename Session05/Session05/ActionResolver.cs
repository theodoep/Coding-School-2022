using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session05
{
    public class ActionResolver
    {
        public MessageLogger Logger { get; set; }

        public ActionResolver()
        {
            Logger = new MessageLogger();
        }
        public ActionResponse Execute(ActionRequest request)
        {
            ActionResponse response = new ActionResponse(request.RequestID, ""); 

            if (request.Action == ActionEnum.Convert)
            {
                int value;
                if (int.TryParse(request.Input, out value))
                {

                    response.Output = DecimalToBinary(value);
                }
                else
                {
                    Logger.Write(new Message("Not a decimal"));
                }
                    
              }
            else if (request.Action == ActionEnum.Uppercase)
            {
                string[] words = request.Input.Split(' ');
                string maxword = FindMaxWord(words);
                if (maxword != string.Empty)
                {
                    response.Output = maxword.ToUpper();
                }
                else Logger.Write(new Message("String is Empty"));
            }
            else if (request.Action == ActionEnum.Reverse)
            {
                response.Output = ReverseString(request.Input);
            }
            else
            {
                Logger.Write(new Message("Error"));
            }
            return response;
        }
        public string DecimalToBinary(int num)
        {
            
            string result;

            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            return result;

        }
        public string FindMaxWord(string[] words)
        {
            int max = 0;
            string maxword = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > max)
                {
                    max = words[i].Length;
                    maxword = words[i];
                }
            }
            return maxword;

        }
        public string ReverseString(string str)
        {
            var charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


    }
}
