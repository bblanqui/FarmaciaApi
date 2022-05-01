using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Farmacia.Core.Interfaces
{
    public  interface IFarmaciaRepository
    {
        Task<IEnumerable<Entities.Farmacia>> GetFarmacias();
    }
}
