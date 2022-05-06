using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Core.DTOs
{
    public class FarmaciaDto
    {
        public string Name { get; set; }
        public string Addres { get; set; }
        public bool? State { get; set; }
        public bool? Online { get; set; }
    }
}
