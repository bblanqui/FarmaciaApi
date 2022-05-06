using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmacia.Core.Interfaces;
using Farmacia.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Farmacia.Infrastructure.Repositories
{
    public class FarmaciaRepository : IFarmaciaRepository
    {
        private readonly FarmaciasContext _context;
        public FarmaciaRepository(FarmaciasContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Core.Entities.Farmacia>> GetFarmacias()
        {
            var farmacias = await _context.Farmacia.ToListAsync();
            return farmacias;
        }
        public async Task<Core.Entities.Farmacia> GetFarmacia(int id)
        {
            var farmacia = await _context.Farmacia.FirstOrDefaultAsync(x=> x.IdFamacia==id);
            return farmacia;
        }

        public async Task InsertPost(Core.Entities.Farmacia farmacia)
        {
            _context.Farmacia.Add(farmacia);
            await _context.SaveChangesAsync();
        }
    }
} 
