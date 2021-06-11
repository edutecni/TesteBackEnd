using EscolaCleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Infra.Data.EntityConfiguration
{
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {            
            builder.Property(d => d.Nome).HasMaxLength(50).IsRequired();
            builder.Property(d => d.Periodo).HasMaxLength(10).IsRequired();
            builder.Property(d => d.RA).HasMaxLength(5).IsRequired();

            // Caso a Tabela Aluno esteja vazia seão adicionados os registros abaixo
            builder.HasData(
                    new Aluno { AlunoId = 1, Nome = "Eduardo Alves Canuto", Periodo = "Manhã", RA = "00001", CursoId = 3 },
                    new Aluno { AlunoId = 2, Nome = "Viviane Fidelis do Nascimento", Periodo = "Tarde", RA = "00002", CursoId = 2 },
                    new Aluno { AlunoId = 3, Nome = "Thiago Fidelis Alves Canuto", Periodo = "Noite", RA = "00003", CursoId = 1 },


                    new Aluno { AlunoId = 4, Nome = "Eduardo Pereira", Periodo = "Manhã", RA = "00004", CursoId = 3 },
                    new Aluno { AlunoId = 5, Nome = "Elaine Farias", Periodo = "Tarde", RA = "00005", CursoId = 3 },
                    new Aluno { AlunoId = 6, Nome = "Eduardo Cout", Periodo = "Noite", RA = "00006", CursoId = 1 },

                    new Aluno { AlunoId = 7, Nome = "Gabriel Silva", Periodo = "Manhã", RA = "00007", CursoId = 3 },
                    new Aluno { AlunoId = 8, Nome = "Viviane Araujo", Periodo = "Tarde", RA = "00008", CursoId = 2 },
                    new Aluno { AlunoId = 9, Nome = "Thiago Silva Farias", Periodo = "Noite", RA = "00009", CursoId = 1 },

                     new Aluno { AlunoId = 10, Nome = "Gabriel Medina", Periodo = "Manhã", RA = "00010", CursoId = 3 },
                    new Aluno { AlunoId = 11, Nome = "Olávo Freitas", Periodo = "Tarde", RA = "00011", CursoId = 2 },
                    new Aluno { AlunoId = 12, Nome = "Nicóle Kidman", Periodo = "Noite", RA = "00012", CursoId = 1 }

                );
        }
    }
}
