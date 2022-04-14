using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model
{
    public class Employee : Base
    {
        public Employee()
        {

        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime HireDateEnd { get; set; }
        public decimal SalaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }
        public List<Transaction> Transactions { get; set; }

    }
    public enum EmployeeTypeEnum
    {
        Manager,
        Cashier,
        Staff
    }
}

