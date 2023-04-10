using Alpha_Matilha.Aplication.DTOs;
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
    public class Classes_DogService
    {
        private IClasses_DogRepository _classesDogRepository;
        private readonly IMapper _mapper;

        public Classes_DogService(IClasses_DogRepository classes_DogRepository, IMapper mapper)
        {
            _classesDogRepository = classes_DogRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Classes_DogDTO>> GetClasses_Dog()
        {
            var classesDogEntity = await _classesDogRepository.GetClasses_DogAsync();
            return _mapper.Map<IEnumerable<Classes_DogDTO>>(classesDogEntity);
        }

        public async Task<Classes_DogDTO> GetById(int? id)
        {
            var classesDogEntity = await _classesDogRepository.GetByIdAsync(id);
            return _mapper.Map<Classes_DogDTO>(classesDogEntity);

        }

        public async Task Add(Classes_DogDTO classesDogDTO)
        {
            var classesDogEntity = _mapper.Map<Classes_Dog>(classesDogDTO);
            await _classesDogRepository.CreateAsync(classesDogEntity);
        }

        //Atualizando
        public async Task UpDate(Classes_DogDTO classesDogDTO)
        {
            var classesDogEntity = _mapper.Map<Classes_Dog>(classesDogDTO);
            await _classesDogRepository.UpdateAsync(classesDogEntity);
        }

        //Remover uma aula por Id
        public async Task Remove(int? id)
        {
            var classesDogEntity = _classesDogRepository.GetByIdAsync(id).Result;
            await _classesDogRepository.RemoveAsync(classesDogEntity);
        }
    }
}
