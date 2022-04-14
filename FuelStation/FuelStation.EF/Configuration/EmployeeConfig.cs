
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configuration
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(emp => emp.ID);
            builder.Property(emp => emp.ID).ValueGeneratedOnAdd();
            builder.Property(emp => emp.Name).HasMaxLength(maxLength: 100);
            builder.Property(emp => emp.Surname).HasMaxLength(maxLength: 100);
            builder.Property(emp => emp.HireDateStart).HasMaxLength(maxLength: 100);
            builder.Property(emp => emp.HireDateEnd).HasMaxLength(maxLength: 100);
            builder.Property(emp => emp.SalaryPerMonth).HasColumnType("decimal(10, 2)");
        
        }
    }
}
