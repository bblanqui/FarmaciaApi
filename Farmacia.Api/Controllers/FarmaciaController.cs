using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Farmacia.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Farmacia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FarmaciaController : ControllerBase
    {
        private readonly IFarmaciaRepository _farmaciaRepository;
        public FarmaciaController(IFarmaciaRepository farmaciaRepository)
        {
            _farmaciaRepository = farmaciaRepository;
            
        }

        // GET: api/<FarmaciaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var farmacias = await _farmaciaRepository.GetFarmacias();
            return Ok(farmacias);
        }
    }

}
