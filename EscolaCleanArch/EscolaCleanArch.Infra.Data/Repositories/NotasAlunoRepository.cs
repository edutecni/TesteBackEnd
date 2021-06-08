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
    public class NotasAlunoRepository : INotasAlunoRepository
    {
        private ApplicationDbContext _context;

        public NotasAlunoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<NotasAluno>> GetNotasAlunos()
        {
            return await _context.NotasAlunos.ToListAsync();
        }

        public async Task<NotasAluno>GetById(int? id)
        {
            return await _context.NotasAlunos.FindAsync(id);
        }

        public void Add(NotasAluno notasAluno)
        {
            _context.Add(notasAluno);
            _context.SaveChanges();
        }

        public void Update(NotasAluno notasAluno)
        {
            _context.Update(notasAluno);
            _context.SaveChanges();
        }

        public void Remove(NotasAluno notasAluno)
        {
            _context.Remove(notasAluno);
            _context.SaveChanges();
        }
    }
}
