using EscolaCleanArch.Infra.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaCleanArch.Infra.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Aluno>Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Alunos Iniciais
            modelBuilder.Entity<Aluno>()
                .Property(a => a.Nome)
                    .HasMaxLength(100);

            modelBuilder.Entity<Aluno>()
                .Property(a => a.Periodo)
                    .HasMaxLength(10);

            modelBuilder.Entity<Aluno>()
                .Property(a => a.RA)
                    .HasMaxLength(5);

            modelBuilder.Entity<Aluno>()
                .HasData(
                    new Aluno { IdAluno = 1, Nome = "Eduardo Alves Canuto", Periodo = Periodo.Manha.ToString(),  RA = "00001" },
                    new Aluno { IdAluno = 2, Nome = "Viviane Fidelis do Nascimento", Periodo = Periodo.Tarde.ToString(), RA = "00002" },
                    new Aluno { IdAluno = 3, Nome = "Thiago Fidelis Alves Canuto", Periodo = Periodo.Noite.ToString(), RA = "00003" });

            // Dicíplinas Iniciais
            modelBuilder.Entity<Diciplina>()
                .Property(d => d.Nome)
                    .HasMaxLength(50);

            modelBuilder.Entity<Diciplina>()
                .Property(d => d.NotaMinima)
                    .HasPrecision(2, 2);

            modelBuilder.Entity<Diciplina>()
                .HasData(
                    new Diciplina { IdDiciplina = 1, Nome = "Portugês", NotaMinima = 7},
                    new Diciplina { IdDiciplina = 2, Nome = "Matemática",NotaMinima = 7},
                    new Diciplina { IdDiciplina = 3, Nome = "Ciências", NotaMinima = 7},
                    new Diciplina { IdDiciplina = 4, Nome = "Histógia", NotaMinima = 7},
                    new Diciplina { IdDiciplina = 5, Nome = "Geográfia", NotaMinima = 7}
                    );

        }
    }
}
