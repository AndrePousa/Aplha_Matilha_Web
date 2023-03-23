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
    public class DogsRepository : IDogRepository
    {
        private AlphaMatilhaContext _dogContext;
        
        public DogsRepository(AlphaMatilhaContext alphaMatilhaContext)
        {
            _dogContext = alphaMatilhaContext;
        }
        public async Task<Dog> CreateAsync(Dog dog)
        {
            _dogContext.Add(dog);
            await _dogContext.SaveChangesAsync();
            return dog;
        }

        public async Task<Dog> GetByIdAsync(int? id)
        {
            return await _dogContext.Dogs.FindAsync(id);
        }

        public async Task<IEnumerable<Dog>> GetDogAsync()
        {
            return await _dogContext.Dogs.ToListAsync();
        }

        public async Task<Dog> RemoveAsync(Dog dog)
        {
            _dogContext.Remove(dog);
            await _dogContext.SaveChangesAsync();
            return dog;
        }

        public async Task<Dog> UpdateAsync(Dog dog)
        {
            _dogContext.Update(dog);
            await _dogContext.SaveChangesAsync();
            return dog;
        }
    }
}
