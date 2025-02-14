using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("address");

            builder.Property(a => a.Id)
                .IsRequired();

            builder.Property(a => a.Career)
                .HasColumnName("career")
                .HasColumnType("varchar(255)");

            builder.Property(a => a.Street)
                .HasColumnName("street")
                .HasColumnType("varchar(255)");

            builder.Property(a => a.Number)
                .HasColumnName("number")
                .HasColumnType("varchar(10)");

            builder.Property(a => a.complement)
                .HasColumnName("complement")
                .HasColumnType("varchar(255)");


            // builder.HasOne(a => a.User)
            //     .WithOne(u => u.Address)
            //     .HasForeignKey<Address>(a => a.User)
            //     .OnDelete(DeleteBehavior.Restrict);



        }
    }
}
