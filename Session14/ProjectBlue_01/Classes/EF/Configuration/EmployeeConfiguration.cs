using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.EF.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            
            builder.ToTable("Employee");

            builder.HasKey(emp => emp.Id);
            builder.Property(emp => emp.Id).ValueGeneratedOnAdd();

            builder.Property(emp => emp.Title).HasMaxLength(100).IsRequired(true);

            builder.HasIndex(emp => emp.Finished).HasName("IX_My_Finished");

            builder.HasOne(emp => emp.Detail).WithOne(empDetail => empDetail.Employee).HasForeignKey<EmployeeDetail>(empDetail => empDetail.EmployeeId);
            builder.HasMany(emp => emp.Comments).WithOne(empComment => empComment.Employee).HasForeignKey(empComment => empComment.EmployeeId);
        }
    }
}
