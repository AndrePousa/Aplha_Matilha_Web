using Alpha_Matilha.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Matilha.Domain.Interfaces
{
    public interface IClasses_DogRepository
    {
        Task<IEnumerable<Classes_Dog>> GetClasses_DogAsync();

        Task<Classes_Dog> GetByIdAsync(int? id);

        Task<Classes_Dog> CreateAsync(Classes_Dog classes_Dog);

        Task<Classes_Dog> UpdateAsync(Classes_Dog classes_Dog);

        Task<Classes_Dog> RemoveAsync(Classes_Dog classes_Dog);
    }
}
