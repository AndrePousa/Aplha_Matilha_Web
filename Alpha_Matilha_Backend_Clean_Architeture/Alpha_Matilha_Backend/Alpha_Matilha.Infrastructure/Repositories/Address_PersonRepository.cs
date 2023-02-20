using Alpha_Matilha.Domain.Entities;
using Alpha_Matilha.Domain.Interfaces;
using Alpha_Matilha.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Matilha.Infrastructure.Repositories
{
    public class Address_PersonRepository : IAddress_PersonRepository
    {
        private AlphaMatilhaContext _address_PersonContext;

        public Address_PersonRepository(AlphaMatilhaContext alphaMatilhaContext)
        {
            _address_PersonContext = alphaMatilhaContext;
        }

        //Criando e adicionando um endereço
        public async Task<Address_Person> CreateAsync(Address_Person address_Person)
        {
            _address_PersonContext.Add(address_Person);
            await _address_PersonContext.SaveChangesAsync();
            return address_Person;

        }

        //retornando uma lista de endereços 
        public async Task<IEnumerable<Address_Person>> GetAddress_PersonAsync()
        {
            return await _address_PersonContext.Address_Persons.ToListAsync();
        }

        public async Task<Address_Person> GetByIdAsync(int? id)
        {
            return await _address_PersonContext.Address_Persons.FindAsync(id);
        }

        public async Task<Address_Person> RemoveAsync(Address_Person address_Person)
        {
            _address_PersonContext.Remove(address_Person);
            await _address_PersonContext.SaveChangesAsync();
            return address_Person;
        }

        public async Task<Address_Person> UpdateAsync(Address_Person address_Person)
        {
            _address_PersonContext.Update(address_Person);
            await _address_PersonContext.SaveChangesAsync();
            return address_Person;
        }
    }
}
