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
    public class CursoRepository : ICursoRepository
    {
        private ApplicationDbContext _context;

        public CursoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Curso>> GetCursos()
        {
            return await _context.Cursos.ToListAsync();
        }

        public async Task<Curso>GetById(int? id)
        {
            return await _context.Cursos.FindAsync(id);
        }

        public void Add(Curso curso)
        {
            _context.Add(curso);
            _context.SaveChanges();
        }

        public void Update(Curso curso)
        {
            _context.Update(curso);
            _context.SaveChanges();
        }

        public void Remove(Curso curso)
        {
            _context.Remove(curso);
            _context.SaveChanges();
        }
    }
}
