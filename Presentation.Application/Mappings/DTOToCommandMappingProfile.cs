﻿using AutoMapper;
using Presentation.Application.DTOs;
using Presentation.Application.PersonalInfos.Commands;
using Presentation.Application.Persons.Commands;

namespace Presentation.Application.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<PersonDTO, PersonCreateCommand>();
            CreateMap<PersonDTO, PersonUpdateCommand>();

            CreateMap<PersonalInfoDTO, PersonalInfoCreateCommand>();
            CreateMap<PersonalInfoDTO, PersonalInfoUpdateCommand>();
        }
    }
}
