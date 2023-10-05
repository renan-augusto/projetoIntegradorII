using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoIntegradorII.Domain.Entities;

namespace ProjetoIntegradorII.Infra.Data.EntitiesConfiguration
{
    public class AdressConfiguration : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Street).HasMaxLength(50).IsRequired();
            builder.Property(c => c.City).HasMaxLength(50).IsRequired();
            builder.Property(z => z.PostalCode).HasMaxLength(10).IsRequired();
            builder.Property(o => o.Country).HasMaxLength(50).IsRequired();
            builder.Property(x => x.State).HasMaxLength(50).IsRequired();
            builder.Property(y => y.AdressNumber).HasMaxLength(5);

        }
    }
}
