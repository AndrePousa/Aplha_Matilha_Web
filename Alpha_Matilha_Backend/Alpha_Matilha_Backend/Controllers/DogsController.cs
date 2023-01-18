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
    public class DogsController : ControllerBase
    {
        private readonly AlphaMatilhaContext _context;

        public DogsController(AlphaMatilhaContext context)
        {
            _context = context;
        }

        // GET: api/Dogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dog>>> GetDog()
        {
            var dogs = await _context.Dog.ToListAsync();  //Não será rastreada a consulta e otimiza as consultas.
            if(dogs is null)
            {
                return NotFound("Cachorro não enconrado");

            }
            return dogs;
        }

        // GET: api/Dogs/5
        [HttpGet("{id:int}", Name = "GetDog")]
        public async Task<ActionResult<Dog>> GetDog(int id)
        {
            var dog = await _context.Dog.FindAsync(id);

            if (dog == null)
            {
                return NotFound("Cachorro não encontrado.");
            }

            return dog;
        }

        // PUT: api/Dogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutDog(int id, Dog dog)
        {
            if (id != dog.ID_Dog)
            {
                return BadRequest();
            }

            _context.Entry(dog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return Ok("Alterado com sucesso.");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DogExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Dogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dog>> PostDog(Dog dog)
        {
            _context.Dog.Add(dog);
            await _context.SaveChangesAsync();

            return new CreatedAtRouteResult("GetDog", new { id = dog.ID_Dog }, dog);
        }

        // DELETE: api/Dogs/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteDog(int id)
        {
            var dog = await _context.Dog.FindAsync(id);
            if (dog == null)
            {
                return NotFound();
            }

            _context.Dog.Remove(dog);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DogExists(int id)
        {
            return _context.Dog.Any(e => e.ID_Dog == id);
        }
    }
}
