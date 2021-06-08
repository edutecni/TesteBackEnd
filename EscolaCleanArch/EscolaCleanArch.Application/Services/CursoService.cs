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
    public class CursoService : ICursoService
    {
        private ICursoRepository _cursoRepository;
        private readonly IMapper _mapper;

        public CursoService(IMapper mapper, ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
            _mapper = mapper;
        }

        public void Add(CursoViewModel curso)
        {
            var mapCurso = _mapper.Map<Curso>(curso);
            _cursoRepository.Add(mapCurso);
        }

        public async Task<CursoViewModel> GetById(int? id)
        {
            var result = await _cursoRepository.GetById(id);
            return _mapper.Map<CursoViewModel>(result);
        }

        public async Task<IEnumerable<CursoViewModel>> GetCursos()
        {
            var result = await _cursoRepository.GetCursos();
            return _mapper.Map<IEnumerable<CursoViewModel>>(result);
        }

        public void Remove(CursoViewModel curso)
        {
            var mapCurso = _mapper.Map<Curso>(curso);
            _cursoRepository.Remove(mapCurso);
        }

        public void Update(CursoViewModel curso)        
        {            
            var mapCurso = _mapper.Map<Curso>(curso);
            _cursoRepository.Update(mapCurso);
        }
    }
}
