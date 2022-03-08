using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session05
{
    public class Message
    {
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; } 
        public string MSG { get; set; }
        
        public Message(string msg)
        {
            ID = Guid.NewGuid();    
            TimeStamp = DateTime.Now;
            MSG = msg;
        }
    }
}
