using Alpha_Matilha.Aplication.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Matilha.Aplication.Interfaces
{
    public interface IDogService
    {
        Task<IEnumerable<DogDTO>> GetDogs();

        Task<DogDTO> GetById(int? id);

        Task Add(DogDTO dogDTO);

        Task UpDate(DogDTO dersonDTO);

        Task Remove(int? id);
    }
}
