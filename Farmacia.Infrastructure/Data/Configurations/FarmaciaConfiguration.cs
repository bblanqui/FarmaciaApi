using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Farmacia.Infrastructure.Data.Configurations
{
    internal class FarmaciaConfiguration : IEntityTypeConfiguration<Core.Entities.Farmacia>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.Farmacia> builder)
        {
            builder.HasKey(e => e.IdFamacia);

            builder.Property(e => e.IdFamacia)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Famacia");

            builder.Property(e => e.Addres)
                .HasColumnName("Direccion")
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Online)
                .HasColumnName("En_Linea");

            builder.Property(e => e.Name)
                .HasColumnName("Nombre")
                .HasMaxLength(500)
                .IsUnicode(false);
            builder.Property(e => e.State)
                .HasColumnName("Estado");
        }
    }
}
