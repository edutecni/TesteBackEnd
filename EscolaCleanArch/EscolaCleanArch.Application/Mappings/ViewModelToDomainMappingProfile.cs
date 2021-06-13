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
    public class ViewModelToDomainMappingProfile : Profile
    {
        // Princípio da inversão de dependência
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<DiciplinaViewModel, Diciplina>();
            CreateMap<AlunoViewModel, Aluno>();
            CreateMap<CursoViewModel, Curso>();
            CreateMap<NotasAlunoViewModel, NotasAluno>();
        }
    }
}
