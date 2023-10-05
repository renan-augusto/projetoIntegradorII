using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoIntegradorII.Domain.Entities;

namespace ProjetoIntegradorII.Infra.Data.EntitiesConfiguration
{
    public class BeneficiaryConfiguration : IEntityTypeConfiguration<Beneficiary>
    {
        public void Configure(EntityTypeBuilder<Beneficiary> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(c => c.LegalNature).IsRequired();
            builder.Property(z => z.Phone).HasMaxLength(15).IsRequired();
            builder.Property(o => o.Active).IsRequired();
            builder.HasOne(b => b.Adress)
                .WithMany(a => a.Beneficiaries)
                .HasForeignKey(b => b.AdressId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
