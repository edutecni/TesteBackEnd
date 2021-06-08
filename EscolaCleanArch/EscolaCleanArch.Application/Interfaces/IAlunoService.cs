using EscolaCleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Application.Interfaces
{
    public interface IAlunoService
    {
        Task<IEnumerable<AlunoViewModel>> GetAlunos();
        Task<AlunoViewModel> GetById(int? id);

        void Add(AlunoViewModel aluno);
        void Update(AlunoViewModel aluno);
        void Remove(AlunoViewModel aluno);
    }
}
