using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Farmacia.Core.DTOs;
using Farmacia.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Farmacia = Farmacia.Core.Entities.Farmacia;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Farmacia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FarmaciaController : ControllerBase
    {
        private readonly IFarmaciaRepository _farmaciaRepository;
        private readonly IMapper _mapper;
        public FarmaciaController(IFarmaciaRepository farmaciaRepository, IMapper mapper)
        {
            _farmaciaRepository = farmaciaRepository;
            _mapper = mapper;

        }

        // GET: api/<FarmaciaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var farmacias = await _farmaciaRepository.GetFarmacias();
            var farmaciasDto = _mapper.Map<IEnumerable<FarmaciaDto>>(farmacias);
            return Ok(farmaciasDto);
        }

        [HttpGet("{id}")] 
        public async Task<IActionResult> GetId(int id)
        {
            var farmacia = await _farmaciaRepository.GetFarmacia(id);
            var farmaciasDto = _mapper.Map<FarmaciaDto>(farmacia);
            return Ok(farmaciasDto);
           
        }


        [HttpPost]
        public async Task<IActionResult> Farmacia(Core.DTOs.FarmaciaDto farmaciaDTO)
        {
            var farmacia = _mapper.Map<Core.Entities.Farmacia>(farmaciaDTO);
            await _farmaciaRepository.InsertPost(farmacia);
            return Ok(farmacia);
        }
    }

}
