using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Farmacia.Core.Interfaces
{
    public  interface IFarmaciaRepository
    {
        public Task<IEnumerable<Entities.Farmacia>> GetFarmacias();
        public Task<Entities.Farmacia> GetFarmacia(int id);
    }
}
