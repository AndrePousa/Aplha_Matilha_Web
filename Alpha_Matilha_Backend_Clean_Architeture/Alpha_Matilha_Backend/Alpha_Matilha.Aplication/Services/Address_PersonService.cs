using Alpha_Matilha.Aplication.DTOs;
using Alpha_Matilha.Aplication.Interfaces;
using Alpha_Matilha.Domain.Entities;
using Alpha_Matilha.Domain.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Matilha.Aplication.Services
{
    public class Address_PersonService : IAddress_PersonService
    {
        private IAddress_PersonRepository _address_PersonRepository;

        private readonly IMapper _mapper;

        public Address_PersonService(IAddress_PersonRepository address_personRepository, IMapper mapper)
        {
            _address_PersonRepository = address_personRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Address_PersonDTO>> GetAddressPersons()
        {
            var address_PersonEntity = await _address_PersonRepository.GetAddress_PersonAsync();
            return _mapper.Map<IEnumerable<Address_PersonDTO>>(address_PersonEntity);
        }


        public async Task<Address_PersonDTO> GetById(int? id)
        {
            var address_PersonEntity = await _address_PersonRepository.GetByIdAsync(id);
            return _mapper.Map<Address_PersonDTO>(address_PersonEntity);
        }

        public async Task Add(Address_PersonDTO address_PersonDTO)
        {
            var address_PersonEntity = _mapper.Map<Address_Person>(address_PersonDTO);
            await _address_PersonRepository.CreateAsync(address_PersonEntity);
        }

        public async Task UpDate(Address_PersonDTO address_PersonDTO)
        {
            var address_PersonEntity = _mapper.Map<Address_Person>(address_PersonDTO);
            await _address_PersonRepository.UpdateAsync(address_PersonEntity);
        }

        public async Task Remove(int? id)
        {
            var address_PersonEntity = _address_PersonRepository.GetByIdAsync(id).Result;
            await _address_PersonRepository.RemoveAsync(address_PersonEntity);
        }
    }
}
