using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model
{
    public class Transaction : Base
    {
        public Transaction()
        {

        }
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }

        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }

    }
    public enum PaymentMethodEnum
    {
        Credit,
        Cash
    }
}

