namespace Fuel_Station.Entities
{
    public class Customer
    {
        public Customer()
        {

        }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }
    }
}
