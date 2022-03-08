using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session05
{
    public class ActionResponse
    {
        public Guid RequestID { get; set; } 
        public Guid ResponseID { get; set; }
        public string Output { get; set; }
        public ActionResponse(Guid requestID, string output)
        {
            ResponseID = Guid.NewGuid();
            Output = output;
            RequestID = requestID;
        }
    }
}
