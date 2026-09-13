using FinTrackAPI.Domain.Entities;
using FinTrackAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinTrackAPI.Mappings
{
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {

        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.ToTable("bills", schema: "fintrack");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(80).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(50);
            builder.Property(x => x.ExpDate);
            builder.HasOne(x => x.User).WithMany(x => x.Bills).HasForeignKey("UserId");
            builder.Property(x => x.Status).HasConversion<string>();
        }
    }
}
