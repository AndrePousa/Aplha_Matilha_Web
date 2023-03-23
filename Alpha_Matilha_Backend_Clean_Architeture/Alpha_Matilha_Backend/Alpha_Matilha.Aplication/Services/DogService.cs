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
    public class DogService : IDogService
    {
        private IDogRepository _dogRepository;
        private readonly IMapper _mapper;

        public DogService(IDogRepository dogRepository, IMapper mapper)
        {
            _dogRepository = dogRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DogDTO>> GetDogs()
        {
            var dogsEntity = await _dogRepository.GetDogAsync();
            return _mapper.Map<IEnumerable<DogDTO>>(dogsEntity);
        }

        public async Task<DogDTO> GetById(int? id)
        {
            var dogEntity = await _dogRepository.GetByIdAsync(id);
            return _mapper.Map<DogDTO>(dogEntity);
        }

        public async Task Add(DogDTO dogDTO)
        {
            var dogEntity = _mapper.Map<Dog>(dogDTO);
            await _dogRepository.CreateAsync(dogEntity);
        }

        public async Task UpDate(DogDTO dogDTO)
        {
            var dogEntity = _mapper.Map<Dog>(dogDTO);
            await _dogRepository.UpdateAsync(dogEntity);
        }

        public async Task Remove(int? id)
        {
            var dogEntity = _dogRepository.GetByIdAsync(id).Result;
            await _dogRepository.RemoveAsync(dogEntity);
        }
    }
}
