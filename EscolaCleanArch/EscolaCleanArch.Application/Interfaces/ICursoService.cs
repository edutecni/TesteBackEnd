using EscolaCleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Application.Interfaces
{
    public interface ICursoService
    {
        Task<IEnumerable<CursoViewModel>> GetCursos();
        Task<CursoViewModel> GetById(int? id);

        void Add(CursoViewModel curso);
        void Update(CursoViewModel curso);
        void Remove(CursoViewModel curso);
    }
}
