using Alpha_Matilha.Aplication.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Matilha.Aplication.Interfaces
{
    internal interface IPersonService
    {
        Task<IEnumerable<PersonDTO>> GetPersons();

        Task<PersonDTO> GetById(int? id);

        Task Add(PersonDTO personDTO);

        Task UpDate(PersonDTO personDTO);

        Task Remove(int? id);
    }
}
