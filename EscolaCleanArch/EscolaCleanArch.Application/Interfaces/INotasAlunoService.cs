using EscolaCleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Application.Interfaces
{
    public interface INotasAlunoService
    {
        Task<IEnumerable<NotasAlunoViewModel>> GetNotasAlunos();
        Task<NotasAlunoViewModel> GetById(int? id);

        void Add(NotasAlunoViewModel notasAluno);
        void Update(NotasAlunoViewModel notasAluno);
        void Remove(NotasAlunoViewModel notasAluno);
    }
}
