
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configuration
{
    public class TransactionLineConfig : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("TransactionLines");
            builder.HasKey(c => c.ID);
            builder.Property(c => c.ID).ValueGeneratedOnAdd();
            builder.HasOne(c => c.Transaction).WithMany(c => c.TransactionLines).HasForeignKey(c => c.TransactionID).IsRequired();
            builder.HasOne(c => c.Item).WithMany().HasForeignKey(c => c.ItemID).IsRequired();
            builder.Property(c => c.Quantity).IsRequired();
            builder.Property(c => c.ItemPrice).IsRequired();
            builder.Property(c => c.NetValue).IsRequired();
            builder.Property(c => c.TotalValue).IsRequired();
            builder.Property(c => c.DiscountValue).IsRequired();
            builder.Property(c => c.DiscountPercent).IsRequired();
        }
    }
}
