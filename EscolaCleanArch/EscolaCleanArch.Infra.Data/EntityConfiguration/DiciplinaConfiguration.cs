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
    public class DiciplinaConfiguration : IEntityTypeConfiguration<Diciplina>
    {
        public void Configure(EntityTypeBuilder<Diciplina> builder)
        {            
            builder.Property(d => d.Nome).HasMaxLength(50).IsRequired();
            builder.Property(d => d.NotaMinima).HasPrecision(10, 2).IsRequired();

            // Caso a Tabela Diciplina esteja vazia seão adicionados os registros abaixo
            builder.HasData(
                    new Diciplina { DiciplinaId = 1, Nome = "Portugês", NotaMinima = 7.0M },
                    new Diciplina { DiciplinaId = 2, Nome = "Matemática", NotaMinima = 7.0M },
                    new Diciplina { DiciplinaId = 3, Nome = "Ciências", NotaMinima = 7.0M },
                    new Diciplina { DiciplinaId = 4, Nome = "Histógia", NotaMinima = 7.0M },
                    new Diciplina { DiciplinaId = 5, Nome = "Geográfia", NotaMinima = 7.0M }
                );
        }
    }
}
