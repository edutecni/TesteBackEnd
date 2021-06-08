using EscolaCleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Domain.Interfaces
{
    public interface IAlunoRepository
    {
        Task<IEnumerable<Aluno>> GetAlunos();
        Task<Aluno> GetById(int? id);

        void Add(Aluno aluno);
        void Update(Aluno aluno);
        void Remove(Aluno aluno);

    }
}
