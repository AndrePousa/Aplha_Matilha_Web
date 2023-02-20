using Alpha_Matilha.Aplication.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Matilha.Aplication.Interfaces
{
    internal interface IClasses_DogService
    {
        Task<IEnumerable<Classes_DogDTO>> GetClassesDogs();

        Task<Classes_DogDTO> GetById(int? id);

        Task Add(Classes_DogDTO classes_DogDTO);

        Task UpDate(Classes_DogDTO classes_DogDTO);

        Task Remove(int? id);
    }
}
