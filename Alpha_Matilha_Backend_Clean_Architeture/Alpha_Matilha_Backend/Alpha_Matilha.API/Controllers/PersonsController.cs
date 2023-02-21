using Alpha_Matilha.Aplication.DTOs;
using Alpha_Matilha.Aplication.Interfaces;
using Alpha_Matilha.Aplication.Services;
using Alpha_Matilha.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace Alpha_Matilha.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        //Obtem todas as pessoas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonDTO>>> GetPersons()
        {
            var person = await _personService.GetPersons();
            return Ok(person);
        }

        //Obtem pessoas por id
        [HttpGet("{id}", Name = "GetPerson")]
        public async Task<ActionResult<Person>> Get(int id)
        {
            var person = await _personService.GetById(id);

            if(person == null)
            {
                return NotFound("ID não encontrado");
            }

            return Ok(person);
        }

        //Insere nova pessoa
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PersonDTO personDTO)
        {
            if(personDTO == null)
            {
                return BadRequest();
            }

            await _personService.Add(personDTO);

            return new CreatedAtRouteResult("GetPerson",
                new { id = personDTO.ID_Person }, personDTO);
        }

        //Deleta a pessoa por id
        [HttpDelete("{id}")]
        public async Task<ActionResult<Person>> Delete(int id)
        {
            var personDTO = await _personService.GetById(id);
            if(personDTO == null)
            {
                return NotFound("Pessoa não encontrada");
            }

            await _personService.Remove(id);
            return Ok(personDTO);
        }
    }
}
