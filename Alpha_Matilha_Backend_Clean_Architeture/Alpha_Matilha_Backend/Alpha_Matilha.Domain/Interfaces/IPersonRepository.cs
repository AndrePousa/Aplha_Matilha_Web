using Alpha_Matilha.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Matilha.Domain.Interfaces
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetPersonAsync();

        Task<Person> GetByIdAsync(int? id);

        Task<Person> CreateAsync(Person person);

        Task<Person> UpdateAsync(Person person);

        Task<Person> RemoveAsync(Person person);
    }
}
