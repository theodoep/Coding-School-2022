namespace Fuel_Station.Entities
{
    public class Transaction
    {
        public Transaction()
        {

        }
        public Guid ID { get; set; }
        public DateTime Date { get; set; }  
        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }

    }
    public enum PaymentMethodEnum
    {
        CreditCard,
        Cash
    }

}
