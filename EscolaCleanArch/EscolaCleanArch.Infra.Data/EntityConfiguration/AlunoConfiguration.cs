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
                    
                    new Aluno (1, "Eduardo Alves Canuto"            , "00001", "Manhã", 3 ),
                    new Aluno (2, "Viviane Fidelis do Nascimento"   , "00002", "Tarde", 2 ),
                    new Aluno (3, "Thiago Fidelis Alves Canuto"     , "00003", "Noite", 1 ),                               
                    new Aluno (4, "Eduardo Pereira"                 , "00004", "Manhã", 3),
                    new Aluno (5, "Elaine Farias"                   , "00005", "Tarde", 3),
                    new Aluno (6, "Eduardo Cout"                    , "00006", "Noite", 1),
                               
                    new Aluno (7, "Gabriel Silva"                   , "00007", "Manhã", 3),
                    new Aluno (8, "Viviane Araujo"                  , "00008", "Tarde", 2),
                    new Aluno (9, "Thiago Silva Farias"             , "00009", "Noite", 1),
                               
                     new Aluno(10, "Gabriel Medina"                 , "00010", "Manhã", 3),
                    new Aluno (11, "Olávo Freitas"                  , "00011", "Tarde", 2),
                    new Aluno (12, "Nicóle Kidman"                  , "00012", "Noite", 1)

                );
        }
    }
}
