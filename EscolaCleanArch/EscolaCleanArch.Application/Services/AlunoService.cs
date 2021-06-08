using AutoMapper;
using EscolaCleanArch.Application.Interfaces;
using EscolaCleanArch.Application.ViewModels;
using EscolaCleanArch.Domain.Entities;
using EscolaCleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Application.Services
{
    public class AlunoService : IAlunoService
    {
        private IAlunoRepository _alunoRepository;
        private readonly IMapper _mapper;

        public AlunoService(IMapper mapper, IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
            _mapper = mapper;
        }

        public void Add(AlunoViewModel aluno)
        {
            var mapAluno = _mapper.Map<Aluno>(aluno);
            _alunoRepository.Add(mapAluno);
        }

        public async Task<AlunoViewModel> GetById(int? id)
        {
            var result = await _alunoRepository.GetById(id);
            return _mapper.Map<AlunoViewModel>(result);
        }

        public async Task<IEnumerable<AlunoViewModel>> GetAlunos()
        {
            var result = await _alunoRepository.GetAlunos();
            return _mapper.Map<IEnumerable<AlunoViewModel>>(result);
        }

        public void Remove(AlunoViewModel aluno)
        {
            var mapAluno = _mapper.Map<Aluno>(aluno);
            _alunoRepository.Remove(mapAluno);
        }

        public void Update(AlunoViewModel aluno)        
        {            
            var mapAluno = _mapper.Map<Aluno>(aluno);
            _alunoRepository.Update(mapAluno);
        }
    }
}
