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
    public class NotasAlunoConfiguration : IEntityTypeConfiguration<NotasAluno>
    {
        public void Configure(EntityTypeBuilder<NotasAluno> builder)
        {
            builder.Property(d => d.NotaDiciplina).HasPrecision(10, 2);

            builder.HasData(
                   new NotasAluno {NotaAlunoId = 1, AlunoId = 1, CursoId = 3, DiciplinaId = 11, NotaDiciplina = 7.0M} ,
                    new NotasAluno { NotaAlunoId = 3, AlunoId = 1, CursoId = 3, DiciplinaId = 12, NotaDiciplina = 9.0M },
                    new NotasAluno { NotaAlunoId = 4, AlunoId = 1, CursoId = 3, DiciplinaId = 13, NotaDiciplina = 5.0M },
                    new NotasAluno { NotaAlunoId = 5, AlunoId = 1, CursoId = 3, DiciplinaId = 14, NotaDiciplina = 8.0M },
                    new NotasAluno { NotaAlunoId = 6, AlunoId = 1, CursoId = 3, DiciplinaId = 15, NotaDiciplina = 6.0M }

               );
        }
    }
}
