using Alpha_Matilha.Domain.Entities;
using Alpha_Matilha.Domain.Interfaces;
using Alpha_Matilha.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Matilha.Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private AlphaMatilhaContext _personContext;

        public PersonRepository(AlphaMatilhaContext personContext)
        {
            _personContext = personContext;
        }
        public async Task<Person> CreateAsync(Person person)
        {
            _personContext.Add(person);
            await _personContext.SaveChangesAsync();
            return person;
        }

        //retornando uma lista de persons
        public async Task<IEnumerable<Person>> GetPersonAsync()
        {
            return await _personContext.Persons.ToListAsync();
        }

        public async Task<Person> GetByIdAsync(int? id)
        {
            return await _personContext.Persons.FindAsync(id);
        }

        public async Task<Person> RemoveAsync(Person person)
        {
            _personContext.Remove(person);
            await _personContext.SaveChangesAsync();
            return person;
        }

        public async Task<Person> UpdateAsync(Person person)
        {
            _personContext.Update(person);
            await _personContext.SaveChangesAsync();
            return person;
        }
    }
}
