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
    public class Classes_DogRepository : IClasses_DogRepository
    {
        private AlphaMatilhaContext _classesDogContext;

        public Classes_DogRepository(AlphaMatilhaContext alphaMatilhaContext)
        {
            _classesDogContext = alphaMatilhaContext;
        }
        //Salvando aula
        public async Task<Classes_Dog> CreateAsync(Classes_Dog classes_Dog)
        {
            _classesDogContext.Add(classes_Dog);
            await _classesDogContext.SaveChangesAsync();
            return classes_Dog;   
        }

        //Obtendo por Id

        public async Task<Classes_Dog> GetByIdAsync(int? id)
        {
            return await _classesDogContext.Classes_Dogs.FindAsync(id);
        }

        //Buscas todoas as aulas
        public async Task<IEnumerable<Classes_Dog>> GetClasses_DogAsync()
        {
            return await _classesDogContext.Classes_Dogs.ToListAsync();
        }

        //Removendo aula
        public async Task<Classes_Dog> RemoveAsync(Classes_Dog classes_Dog)
        {
            _classesDogContext.Remove(classes_Dog);
            await _classesDogContext.SaveChangesAsync();
            return classes_Dog;
        }

        public async Task<Classes_Dog> UpdateAsync(Classes_Dog classes_Dog)
        {
            _classesDogContext.Update(classes_Dog);
            await _classesDogContext.SaveChangesAsync();
            return classes_Dog;
        }
    }
}
