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
    public class CursoConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {            
            builder.Property(d => d.Nome).HasMaxLength(50).IsRequired();

            // add-migration Inicial
            // update-database
            // Caso a Tabela Curso esteja vazia seão adicionados os registros abaixo
            builder.HasData(
                    new Curso { CursoId = 1, Nome = "Ensino Fundamental" },
                    new Curso { CursoId = 2, Nome = "Ensino Médio"},
                    new Curso { CursoId = 3, Nome = "Faculdade" },
                    new Curso { CursoId = 4, Nome = "Pós-Graduação" }
                );
        }
    }
}
