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
    public class NotasAlunoService : INotasAlunoService
    {
        private INotasAlunoRepository _notasAlunoRepository;
        private readonly IMapper _mapper;

        public NotasAlunoService(IMapper mapper, INotasAlunoRepository notasAlunoRepository)
        {
            _notasAlunoRepository = notasAlunoRepository;
            _mapper = mapper;
        }

        public void Add(NotasAlunoViewModel notasAluno)
        {
            var mapNotasAluno = _mapper.Map<NotasAluno>(notasAluno);
            _notasAlunoRepository.Add(mapNotasAluno);
        }

        public async Task<NotasAlunoViewModel> GetById(int? id)
        {
            var result = await _notasAlunoRepository.GetById(id);
            return _mapper.Map<NotasAlunoViewModel>(result);
        }

        public async Task<IEnumerable<NotasAlunoViewModel>> GetNotasAlunos()
        {
            var result = await _notasAlunoRepository.GetNotasAlunos();
            return _mapper.Map<IEnumerable<NotasAlunoViewModel>>(result);
        }

        public void Remove(NotasAlunoViewModel notasAluno)
        {
            var mapNotasAluno = _mapper.Map<NotasAluno>(notasAluno);
            _notasAlunoRepository.Remove(mapNotasAluno);
        }

        public void Update(NotasAlunoViewModel notasAluno)        
        {            
            var mapNotasAluno = _mapper.Map<NotasAluno>(notasAluno);
            _notasAlunoRepository.Update(mapNotasAluno);
        }
    }
}
