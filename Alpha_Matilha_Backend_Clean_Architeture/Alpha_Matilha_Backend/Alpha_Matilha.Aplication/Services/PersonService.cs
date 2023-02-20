using Alpha_Matilha.Aplication.Interfaces;
using Alpha_Matilha.Aplication.DTOs;
using AutoMapper;
using Alpha_Matilha.Domain.Interfaces;
using Alpha_Matilha.Domain.Entities;

namespace Alpha_Matilha.Aplication.Services
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _personRepository;

        private readonly IMapper _mapper;

        public PersonService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PersonDTO>> GetPersons()
        {
            var personEntity = await _personRepository.GetPersonAsync();
            return _mapper.Map<IEnumerable<PersonDTO>>(personEntity);
        }

        public async Task<PersonDTO> GetById(int? id)
        {
            var personEntity = await _personRepository.GetByIdAsync(id);
            return _mapper.Map<PersonDTO>(personEntity);
        }

        public async Task Add(PersonDTO personDTO)
        {
            var personEntity = _mapper.Map<Person>(personDTO);
            await _personRepository.CreateAsync(personEntity);
        }

        public async Task UpDate(PersonDTO personDTO)
        {
            var personEntity = _mapper.Map<Person>(personDTO);
            await _personRepository.UpdateAsync(personEntity);
        }

        public async Task Remove(int? id)
        {
            var personEntity = _personRepository.GetByIdAsync(id).Result;
            await _personRepository.RemoveAsync(personEntity);
        }

    }
}
