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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Diciplina> Diciplinas { get; set; }

        //public DbSet<Aluno>Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DiciplinaConfiguration());

            //// Dicíplinas Iniciais
            //modelBuilder.Entity<Diciplina>()
            //    .Property(d => d.Nome)
            //        .HasMaxLength(50);

            //modelBuilder.Entity<Diciplina>()
            //    .Property(d => d.NotaMinima)
            //        .HasPrecision(10, 2);

            //// Alunos Iniciais
            //modelBuilder.Entity<Aluno>()
            //    .Property(a => a.Nome)
            //        .HasMaxLength(100);

            //modelBuilder.Entity<Aluno>()
            //    .Property(a => a.Periodo)
            //        .HasMaxLength(10);

            //modelBuilder.Entity<Aluno>()
            //    .Property(a => a.RA)
            //        .HasMaxLength(5);

            //modelBuilder.Entity<Aluno>()
            //    .HasData(
            //        new Aluno { AlunoId = 1, Nome = "Eduardo Alves Canuto", Periodo = "Manhã",  RA = "00001" },
            //        new Aluno { AlunoId = 2, Nome = "Viviane Fidelis do Nascimento", Periodo = "Tarde", RA = "00002" },
            //        new Aluno { AlunoId = 3, Nome = "Thiago Fidelis Alves Canuto", Periodo = "Noite", RA = "00003" });



            //modelBuilder.Entity<Diciplina>()
            //    .HasData(
            //        new Diciplina { DiciplinaId = 1, Nome = "Portugês", NotaMinima = 7.0M },
            //        new Diciplina { DiciplinaId = 2, Nome = "Matemática", NotaMinima = 7.0M },
            //        new Diciplina { DiciplinaId = 3, Nome = "Ciências", NotaMinima = 7.0M },
            //        new Diciplina { DiciplinaId = 4, Nome = "Histógia", NotaMinima = 7.0M },
            //        new Diciplina { DiciplinaId = 5, Nome = "Geográfia", NotaMinima = 7.0M }
            //        );

            }
        }
}
