using Alpha_Matilha.Aplication.DTOs;
using Alpha_Matilha.Aplication.Interfaces;
using Alpha_Matilha.Aplication.Services;
using Alpha_Matilha.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Alpha_Matilha.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        private readonly IDogService _dogService;

        public DogsController(IDogService dogService)
        {
            _dogService = dogService;
        }

        //Busca Todos os Cães 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DogDTO>>> Get()
        {
            var dogs = await _dogService.GetDogs();
            return Ok(dogs);
        }

        //Busca o cão por ID
        [HttpGet("{id}", Name = "GetDog")]
        public async Task<ActionResult<Dog>> Get(int id)
        {
            var dog = await _dogService.GetById(id);

            if(dog == null)
            {
                return NotFound("id não encontrado");
            }
            return Ok(dog);
        }

        //insere novo cão
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DogDTO dogDto)
        {
            if (dogDto == null)
            {
                return BadRequest(ModelState);
            }

            await _dogService.Add(dogDto);

            return new CreatedAtRouteResult("GetDog",
                new { id = dogDto.ID_Dog }, dogDto);
        }

        //Atualizando cão
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] DogDTO dogDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != dogDto.ID_Dog)
            {
                return BadRequest();
            }
            await _dogService.UpDate(dogDto);
            return Ok(dogDto);
        }

        //Deleta o cão por id
        [HttpDelete("{id}")]
        public async Task<ActionResult<Dog>> Delete(int id)
        {
            var dogDTO = await _dogService.GetById(id);
            if (dogDTO == null)
            {
                return NotFound("Pessoa não encontrada");
            }

            await _dogService.Remove(id);
            return Ok(dogDTO);
        }
    }
}
