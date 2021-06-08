using EscolaCleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Domain.Interfaces
{
    public interface ICursoRepository
    {
        Task<IEnumerable<Curso>> GetCursos();
        Task<Curso> GetById(int? id);

        void Add(Curso curso);
        void Update(Curso curso);
        void Remove(Curso curso);

    }
}
