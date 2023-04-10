using Alpha_Matilha.Aplication.DTOs;
using Alpha_Matilha.Aplication.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Alpha_Matilha.Domain.Entities;
using Alpha_Matilha.Aplication.Services;

namespace Alpha_Matilha.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Address_PersonsController : ControllerBase
    {
        private readonly IAddress_PersonService _address_PersonService;  

        public Address_PersonsController(IAddress_PersonService address_PersonService)
        {
            _address_PersonService = address_PersonService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Address_PersonDTO>>> GetAddress_Persons()
        {
            var address_Person = await _address_PersonService.GetAddressPersons();
            return Ok(address_Person);

        }
        [HttpGet("{id}", Name = "GetAddress_Person")]
        public async Task<ActionResult<Address_Person>> Get(int id)
        {
            var address_person = await _address_PersonService.GetById(id);

            if(address_person == null)
            {
                return NotFound("ID não encontrado");
            }
            return Ok(address_person);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Address_PersonDTO address_PersonDTO)
        {
            if (address_PersonDTO == null)
            {
                return BadRequest();
            }

            await _address_PersonService.Add(address_PersonDTO);
            

            return new CreatedAtRouteResult("GetAddress_Person",
                new { id = address_PersonDTO.ID_Address }, address_PersonDTO);
        }

        //Atualizando Address_Person
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Address_PersonDTO address_PersonDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != address_PersonDto.ID_Person)
            {
                return BadRequest();
            }
            await _address_PersonService.UpDate(address_PersonDto);
            return Ok(address_PersonDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Address_Person>> Delete(int id)
        {
            var address_PersonDTO = await _address_PersonService.GetById(id);
            if(address_PersonDTO == null){
                return NotFound("Endereço Não encontrado");
            }
            await _address_PersonService.Remove(id);
            return Ok(address_PersonDTO);
        }

    }
}
