
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configuration
{
    public class ItemConfig : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");
            builder.HasKey(item => item.ID);
            builder.Property(item => item.ID).ValueGeneratedOnAdd();
            builder.Property(item => item.Code).HasMaxLength(50);
            builder.Property(item => item.Description).HasMaxLength(50);
            builder.Property(item => item.Price).HasColumnType("decimal(10, 2)");
            builder.Property(item => item.Cost).HasColumnType("decimal(10, 2)");

        }

    }
}
