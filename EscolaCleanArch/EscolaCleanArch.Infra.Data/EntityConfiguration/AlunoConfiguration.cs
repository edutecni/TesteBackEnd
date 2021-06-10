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
                    new Aluno { AlunoId = 3, Nome = "Thiago Fidelis Alves Canuto", Periodo = "Noite", RA = "00003", CursoId = 1 }
                    
                );
        }
    }
}
