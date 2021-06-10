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
            //builder.Property(d => d.Nome).IsRequired();

            // Caso a Tabela Diciplina esteja vazia seão adicionados os registros abaixo
            builder.HasData(
                    new Diciplina { DiciplinaId = 1, Nome = "Portugês Ensino Fundamental", NotaMinima = 7.0M},
                    new Diciplina { DiciplinaId = 2, Nome = "Matemática Ensino Fundamental", NotaMinima = 7.0M },
                    new Diciplina { DiciplinaId = 3, Nome = "Ciências Ensino Fundamental", NotaMinima = 7.0M },
                    new Diciplina { DiciplinaId = 4, Nome = "Histógia Ensino Fundamental", NotaMinima = 7.0M },
                    new Diciplina { DiciplinaId = 5, Nome = "Geográfia Ensino Fundamental", NotaMinima = 7.0M },

                    new Diciplina { DiciplinaId = 6, Nome = "Portugês Ensino Médio", NotaMinima = 7.0M },
                    new Diciplina { DiciplinaId = 7, Nome = "Matemática Ensino Médio", NotaMinima = 7.0M },
                    new Diciplina { DiciplinaId = 8, Nome = "Fisíca Ensino Médio", NotaMinima = 7.0M },
                    new Diciplina { DiciplinaId = 9, Nome = "Histógia Ensino Médio", NotaMinima = 7.0M },
                    new Diciplina { DiciplinaId = 10, Nome = "Geográfia Ensino Médio", NotaMinima = 7.0M },

                    new Diciplina { DiciplinaId = 11, Nome = "Portugês Faculdade", NotaMinima = 7.0M },
                    new Diciplina { DiciplinaId = 12, Nome = "Matemática Faculdade", NotaMinima = 7.0M },
                    new Diciplina { DiciplinaId = 13, Nome = "Fisíca Faculdade", NotaMinima = 7.0M },
                    new Diciplina { DiciplinaId = 14, Nome = "Histógia Faculdade", NotaMinima = 7.0M },
                    new Diciplina { DiciplinaId = 15, Nome = "Geográfia Faculdade", NotaMinima = 7.0M }
                );
        }
    }
}
