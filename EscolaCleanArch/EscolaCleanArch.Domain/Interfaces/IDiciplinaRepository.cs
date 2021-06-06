using EscolaCleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Domain.Interfaces
{
    public interface IDiciplinaRepository
    {
        Task<IEnumerable<Diciplina>> GetDiciplinas();
        Task<Diciplina> GetById(int? id);

        void Add(Diciplina diciplina);
        void Update(Diciplina diciplina);
        void Remove(Diciplina diciplina);

    }
}
