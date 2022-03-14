using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClassLibrary
{

    public class Institute
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }
        public Institute()
        {
            ID = Guid.NewGuid();
        }
        public Institute(string name, int years)
        {
            ID = Guid.NewGuid();
            Name = name;
            YearsInService = years;

        }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;

        }
    }
}
        
