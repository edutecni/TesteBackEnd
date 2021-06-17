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
    public class AlunoRepository : IAlunoRepository
    {
        private ApplicationDbContext _context;

        public AlunoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Aluno>> GetAlunos()
        {
            return await _context.Alunos.ToListAsync();
        }

        public async Task<Aluno>GetById(int? id)
        {
            return await _context.Alunos.FindAsync(id);
        }

        public void Add(Aluno aluno)
        {            
            _context.Add(aluno);
            _context.SaveChanges();
        }

        public void Update(Aluno aluno)
        {
            _context.Update(aluno);
            _context.SaveChanges();
        }

        public void Remove(Aluno aluno)
        {
            var objResult = GetById(aluno.AlunoId).Result;
            if (objResult is not null)
            {
                _context.Remove(objResult);
                _context.SaveChanges();
            }
           
        }
    }
}
