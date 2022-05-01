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
    }
}
