using EscolaCleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Domain.Interfaces
{
    public interface INotasAlunoRepository
    {
        Task<IEnumerable<NotasAluno>> GetNotasAlunos();
        Task<NotasAluno> GetById(int? id);

        void Add(NotasAluno notasAluno);
        void Update(NotasAluno notasAluno);
        void Remove(NotasAluno notasAluno);

    }
}
