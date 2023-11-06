using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoIntegradorII.Domain.Entities;

namespace ProjetoIntegradorII.Infra.Data.EntitiesConfiguration
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Amount).HasColumnType("decimal(18, 2)").IsRequired();
            builder.Property(p => p.PaymentDate).IsRequired();
            builder.HasOne<Title>()
                .WithMany()
                .HasForeignKey(p => p.TitleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
