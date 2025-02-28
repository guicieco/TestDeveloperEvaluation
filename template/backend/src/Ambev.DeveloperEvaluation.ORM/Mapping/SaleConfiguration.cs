#region Using

using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

#endregion

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sales");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");
            builder.Property(u => u.SaleNumber).ValueGeneratedOnAdd();
            
            builder.Property(u => u.CustomerId);
            builder.Property(u => u.BranchId);
            builder.Property(u => u.Discount);
            builder.Property(u => u.CreatedAt);
            builder.Property(u => u.UpdatedAt);
            builder.Property(u => u.Total);
            builder.Property(u => u.TotalDiscount);
            

            builder.Property(u => u.Status)
            .HasConversion<string>()
            .HasMaxLength(20);
        }
    }
}
