using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03
{
    public class Person
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Person()
        {

        }
        public Person(string name, int age)
        {
            ID = Guid.NewGuid();
            Name = name;
            Age = age;
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
