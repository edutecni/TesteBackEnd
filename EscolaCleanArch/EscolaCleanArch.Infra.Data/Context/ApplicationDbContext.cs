using EscolaCleanArch.Domain.Entities;
using EscolaCleanArch.Infra.Data.EntityConfiguration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaCleanArch.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        // add-migration Inicial
        // update-database
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Diciplina> Diciplinas { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<NotasAluno> NotasAlunos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DiciplinaConfiguration());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AlunoConfiguration());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CursoConfiguration());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new NotasAlunoConfiguration());
        }

    }
}
