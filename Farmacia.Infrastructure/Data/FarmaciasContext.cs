using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Farmacia.Infrastructure.Data
{
    public  class FarmaciasContext : DbContext
    {
        public FarmaciasContext()
        {
        }

        public FarmaciasContext(DbContextOptions<FarmaciasContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Core.Entities.Farmacia> Farmacia { get; set; }

    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Core.Entities.Farmacia>(entity =>
            {
                entity.HasKey(e => e.IdFamacia);

                entity.Property(e => e.IdFamacia)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id_Famacia");

                entity.Property(e => e.Addres)
                    .HasColumnName("Direccion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Online)
                    .HasColumnName("En_Linea");

                entity.Property(e => e.Name)
                    .HasColumnName("Nombre")
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.State)
                    .HasColumnName("Estado");
            });

        }


    }
}
