namespace Fuel_Station.Entities
{
    public class Employee
    {
        public Employee()
        {

        }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime HireDateEnd { get; set; }
        public decimal SalaryPerMonth  { get; set; }
        public EmployeeTypeNum EmployeeType { get; set; }

    }
    public enum EmployeeTypeNum
    {
        Manager,
        Cashier,
        Staff
    }
}
