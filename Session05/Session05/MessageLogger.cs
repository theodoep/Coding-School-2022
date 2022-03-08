using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session05
{
    public abstract class Logger
    {
        public Logger()
        {

        }
        abstract public void ReadAll();
        abstract public void Clear();
    }
    public class MessageLogger : Logger
    {
        public Message[] Messages { get; set; }
        public MessageLogger()

        {
            Messages = new Message[50];
        }
        public override void ReadAll()
        {
            for (int i = 0; i < Messages.Length; i++)
            {
                Console.WriteLine(Messages[i].MSG);
            }
        }
        public override void Clear()
        {
            Messages = new Message[50];
        }
        public void Write(Message message)
        {
            Messages.Append(message);
        }
    }
}
