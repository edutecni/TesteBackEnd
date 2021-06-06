using EscolaCleanArch.Domain.Entities;
using EscolaCleanArch.Domain.Interfaces;
using EscolaCleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Infra.Data.Repositories
{
    public class DiciplinaRepository : IDiciplinaRepository
    {
        private ApplicationDbContext _context;

        public DiciplinaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Diciplina>> GetDiciplinas()
        {
            return await _context.Diciplinas.ToListAsync();
        }

        public async Task<Diciplina>GetById(int? id)
        {
            return await _context.Diciplinas.FindAsync(id);
        }

        public void Add(Diciplina diciplina)
        {
            _context.Add(diciplina);
            _context.SaveChanges();
        }

        public void Update(Diciplina diciplina)
        {
            _context.Update(diciplina);
            _context.SaveChanges();
        }

        public void Remove(Diciplina diciplina)
        {
            _context.Remove(diciplina);
            _context.SaveChanges();
        }
    }
}
