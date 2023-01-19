using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Alpha_Matilha_Backend.Models;
using Alpha_Matilha_Backend.Repository.Context;

namespace Alpha_Matilha_Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Address_PersonController : ControllerBase
    {
        private readonly AlphaMatilhaContext _context;

        public Address_PersonController(AlphaMatilhaContext context)
        {
            _context = context;
        }

        // GET: api/Address_Person
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Address_Person>>> GetAddress_Person()
        {
            return await _context.Address_Person.ToListAsync();
        }

        // GET: api/Address_Person/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Address_Person>> GetAddress_Person(int id)
        {
            var address_Person = await _context.Address_Person.FindAsync(id);

            if (address_Person == null)
            {
                return NotFound();
            }

            return address_Person;
        }

        // PUT: api/Address_Person/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutAddress_Person(int id, Address_Person address_Person)
        {
            if (id != address_Person.ID_Address)
            {
                return BadRequest();
            }

            _context.Entry(address_Person).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Address_PersonExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(address_Person);
        }

        // POST: api/Address_Person
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Address_Person>> PostAddress_Person(Address_Person address_Person)
        {
            if (address_Person == null)
                return BadRequest();

            _context.Address_Person.Add(address_Person);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAddress_Person", new { id = address_Person.ID_Address }, address_Person);
        }

        // DELETE: api/Address_Person/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress_Person(int id)
        {
            var address_Person = await _context.Address_Person.FindAsync(id);
            if (address_Person == null)
            {
                return NotFound();
            }

            _context.Address_Person.Remove(address_Person);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Address_PersonExists(int id)
        {
            return _context.Address_Person.Any(e => e.ID_Address == id);
        }
    }
}
