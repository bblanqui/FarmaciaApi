using System;
using System.Collections.Generic;



namespace Farmacia.Core.Entities
{
    public  class Farmacia
    {
        public int IdFamacia { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }
        public bool? State { get; set; }
        public bool? Online { get; set; }
    }
}
