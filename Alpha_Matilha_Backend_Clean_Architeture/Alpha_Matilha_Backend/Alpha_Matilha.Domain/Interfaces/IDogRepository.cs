using Alpha_Matilha.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Matilha.Domain.Interfaces
{
    public interface IDogRepository
    {
        Task<IEnumerable<Dog>> GetDogAsync();

        Task<Dog> GetByIdAsync(int? id);

        Task<Dog> CreateAsync(Dog dog);

        Task<Dog> UpdateAsync(Dog dog);

        Task<Dog> RemoveAsync(Dog dog);
    }
}
