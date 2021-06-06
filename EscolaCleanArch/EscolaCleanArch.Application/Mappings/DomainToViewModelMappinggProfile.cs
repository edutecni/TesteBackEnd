using AutoMapper;
using EscolaCleanArch.Application.ViewModels;
using EscolaCleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Application.Mappings
{
    public class DomainToViewModelMappinggProfile : Profile
    {
        public DomainToViewModelMappinggProfile()
        {
            CreateMap<Diciplina, DiciplinaViewModel>();
        }
    }
}
