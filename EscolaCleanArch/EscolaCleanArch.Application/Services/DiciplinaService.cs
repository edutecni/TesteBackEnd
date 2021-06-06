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
    public class DiciplinaService : IDiciplinaService
    {
        private IDiciplinaRepository _diciplinaRepository;
        private readonly IMapper _mapper;

        public DiciplinaService(IMapper mapper, IDiciplinaRepository diciplinaRepository)
        {
            _diciplinaRepository = diciplinaRepository;
            _mapper = mapper;
        }

        public void Add(DiciplinaViewModel diciplina)
        {
            var mapDiciplina = _mapper.Map<Diciplina>(diciplina);
            _diciplinaRepository.Add(mapDiciplina);
        }

        public async Task<DiciplinaViewModel> GetById(int? id)
        {
            var result = await _diciplinaRepository.GetById(id);
            return _mapper.Map<DiciplinaViewModel>(result);
        }

        public async Task<IEnumerable<DiciplinaViewModel>> GetDiciplinas()
        {
            var result = await _diciplinaRepository.GetDiciplinas();
            return _mapper.Map<IEnumerable<DiciplinaViewModel>>(result);
        }

        public void Remove(DiciplinaViewModel diciplina)
        {
            var mapDiciplina = _mapper.Map<Diciplina>(diciplina);
            _diciplinaRepository.Remove(mapDiciplina);
        }

        public void Update(DiciplinaViewModel diciplina)        
        {            
            var mapDiciplina = _mapper.Map<Diciplina>(diciplina);
            _diciplinaRepository.Update(mapDiciplina);
        }
    }
}
