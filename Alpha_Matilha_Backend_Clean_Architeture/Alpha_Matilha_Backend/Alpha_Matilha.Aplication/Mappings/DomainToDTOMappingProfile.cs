using Alpha_Matilha.Aplication.DTOs;
using Alpha_Matilha.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Matilha.Aplication.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Address_Person, Address_PersonDTO>().ReverseMap();

            CreateMap<Classes_Dog, Classes_DogDTO>().ReverseMap();

            CreateMap<Dog, DogDTO>().ReverseMap();

            CreateMap<Person, PersonDTO>().ReverseMap();

        }
    }
}
