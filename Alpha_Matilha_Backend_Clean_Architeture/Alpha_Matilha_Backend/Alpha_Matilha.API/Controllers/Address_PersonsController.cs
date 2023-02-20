using Alpha_Matilha.Aplication.DTOs;
using Alpha_Matilha.Aplication.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
