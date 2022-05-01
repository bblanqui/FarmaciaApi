using System;
using Farmacia.Infrastructure.Data.Configurations;
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
            modelBuilder.ApplyConfiguration(new FarmaciaConfiguration());

        }


    }
}
