using Alpha_Matilha.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Matilha.Domain.Interfaces
{
    public interface IAddress_PersonRepository
    {
        Task<IEnumerable<Address_Person>> GetAddress_PersonAsync();

        Task<Address_Person> GetByIdAsync(int? id);

        Task<Address_Person> CreateAsync(Address_Person address_Person);

        Task<Address_Person> UpdateAsync(Address_Person address_Person);

        Task<Address_Person> RemoveAsync(Address_Person address_Person);
    }
}
