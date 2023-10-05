using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoIntegradorII.Domain.Entities;

namespace ProjetoIntegradorII.Infra.Data.EntitiesConfiguration
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(t => t.Amount).HasColumnType("decimal(18, 2)").IsRequired();
            builder.Property(t => t.DueDate).IsRequired();
            builder.Property(t => t.PaymentDate).IsRequired();
            builder.Property(t => t.Status).IsRequired();
        }
    }
}
