using EscolaCleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Application.Interfaces
{
    public interface IDiciplinaService
    {
        Task<IEnumerable<DiciplinaViewModel>> GetDiciplinas();
        Task<DiciplinaViewModel> GetById(int? id);

        void Add(DiciplinaViewModel diciplina);
        void Update(DiciplinaViewModel diciplina);
        void Remove(DiciplinaViewModel diciplina);
    }
}
