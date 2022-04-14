using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared
{
    public class CustomerListViewModel : Base
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }
    }
    public class CustomerEditViewModel : Base
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }
    }
}
