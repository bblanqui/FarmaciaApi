using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Farmacia.Core.DTOs;

namespace Farmacia.Infrastructure.Mappings
{
    public class AutomapperProfile:Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Core.Entities.Farmacia, FarmaciaDto>();
            CreateMap<FarmaciaDto, Core.Entities.Farmacia>();

        }
    }
}
