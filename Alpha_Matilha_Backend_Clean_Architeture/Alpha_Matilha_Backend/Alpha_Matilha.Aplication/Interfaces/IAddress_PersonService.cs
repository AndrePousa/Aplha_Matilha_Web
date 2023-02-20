using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alpha_Matilha.Domain.Entities;
using Alpha_Matilha.Aplication.DTOs;

namespace Alpha_Matilha.Aplication.Interfaces
{
    public interface IAddress_PersonService
    {
        Task<IEnumerable<Address_PersonDTO>> GetAddressPersons();

        Task<Address_PersonDTO> GetById(int? id);

        Task Add(Address_PersonDTO personDTO);

        Task UpDate(Address_PersonDTO personDTO);

        Task Remove(int? id);
    }
}
