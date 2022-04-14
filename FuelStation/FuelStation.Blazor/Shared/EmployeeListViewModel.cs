using FuelStation.Model;

namespace FuelStation.Blazor.Shared
{
    public class EmployeeListViewModel : Base
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime HireDateEnd { get; set; }
        public decimal SalaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }
    }
    public class EmployeeEditViewModel : Base
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime HireDateEnd { get; set; }
        public decimal SalaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }
    }
}
