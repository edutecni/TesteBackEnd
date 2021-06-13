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
                    new NotasAluno { NotaAlunoId = 2, AlunoId = 1, CursoId = 3, DiciplinaId = 12, NotaDiciplina = 9.0M },
                    new NotasAluno { NotaAlunoId = 3, AlunoId = 1, CursoId = 3, DiciplinaId = 13, NotaDiciplina = 5.0M },
                    new NotasAluno { NotaAlunoId = 4, AlunoId = 1, CursoId = 3, DiciplinaId = 14, NotaDiciplina = 8.0M },
                    new NotasAluno { NotaAlunoId = 5, AlunoId = 1, CursoId = 3, DiciplinaId = 15, NotaDiciplina = 6.0M },

                    new NotasAluno { NotaAlunoId = 6, AlunoId = 4, CursoId = 3, DiciplinaId = 11, NotaDiciplina = 7.0M },
                    new NotasAluno { NotaAlunoId = 7, AlunoId = 4, CursoId = 3, DiciplinaId = 12, NotaDiciplina = 7.0M },
                    new NotasAluno { NotaAlunoId = 8, AlunoId = 4, CursoId = 3, DiciplinaId = 13, NotaDiciplina = 5.0M },
                    new NotasAluno { NotaAlunoId = 9, AlunoId = 4, CursoId = 3, DiciplinaId = 14, NotaDiciplina = 8.0M },
                    new NotasAluno { NotaAlunoId = 10, AlunoId = 4, CursoId = 3, DiciplinaId = 15, NotaDiciplina = 9.0M },

                    new NotasAluno { NotaAlunoId = 11, AlunoId = 5, CursoId = 3, DiciplinaId = 11, NotaDiciplina = 10.0M },
                    new NotasAluno { NotaAlunoId = 12, AlunoId = 5, CursoId = 3, DiciplinaId = 12, NotaDiciplina = 9.0M },
                    new NotasAluno { NotaAlunoId = 13, AlunoId = 5, CursoId = 3, DiciplinaId = 13, NotaDiciplina = 8.0M },
                    new NotasAluno { NotaAlunoId = 14, AlunoId = 5, CursoId = 3, DiciplinaId = 14, NotaDiciplina = 5.0M },
                    new NotasAluno { NotaAlunoId = 15, AlunoId = 5, CursoId = 3, DiciplinaId = 15, NotaDiciplina = 6.0M },

                    new NotasAluno { NotaAlunoId = 16, AlunoId = 3, CursoId = 1, DiciplinaId = 1, NotaDiciplina = 7.0M },
                    new NotasAluno { NotaAlunoId = 17, AlunoId = 3, CursoId = 1, DiciplinaId = 2, NotaDiciplina = 9.0M },
                    new NotasAluno { NotaAlunoId = 18, AlunoId = 3, CursoId = 1, DiciplinaId = 3, NotaDiciplina = 9.0M },
                    new NotasAluno { NotaAlunoId = 19, AlunoId = 3, CursoId = 1, DiciplinaId = 4, NotaDiciplina = 5.0M },
                    new NotasAluno { NotaAlunoId = 20, AlunoId = 3, CursoId = 1, DiciplinaId = 5, NotaDiciplina = 9.0M },
                   
                    new NotasAluno { NotaAlunoId = 21, AlunoId = 6, CursoId = 1, DiciplinaId = 1, NotaDiciplina = 6.0M },
                    new NotasAluno { NotaAlunoId = 22, AlunoId = 6, CursoId = 1, DiciplinaId = 2, NotaDiciplina = 7.0M },
                    new NotasAluno { NotaAlunoId = 23, AlunoId = 6, CursoId = 1, DiciplinaId = 3, NotaDiciplina = 9.0M },
                    new NotasAluno { NotaAlunoId = 24, AlunoId = 6, CursoId = 1, DiciplinaId = 4, NotaDiciplina = 8.0M },
                    new NotasAluno { NotaAlunoId = 25, AlunoId = 6, CursoId = 1, DiciplinaId = 5, NotaDiciplina = 10.0M },

                    new NotasAluno { NotaAlunoId = 26, AlunoId = 2, CursoId = 2, DiciplinaId = 6, NotaDiciplina = 10.0M },
                    new NotasAluno { NotaAlunoId = 27, AlunoId = 2, CursoId = 2, DiciplinaId = 7, NotaDiciplina = 9.0M },
                    new NotasAluno { NotaAlunoId = 28, AlunoId = 2, CursoId = 2, DiciplinaId = 8, NotaDiciplina = 9.0M },
                    new NotasAluno { NotaAlunoId = 29, AlunoId = 2, CursoId = 2, DiciplinaId = 9, NotaDiciplina = 9.0M },
                    new NotasAluno { NotaAlunoId = 30, AlunoId = 2, CursoId = 2, DiciplinaId = 10, NotaDiciplina = 10.0M },
                                                                              
                    new NotasAluno { NotaAlunoId = 31, AlunoId = 8, CursoId = 2, DiciplinaId = 6, NotaDiciplina = 8.0M },
                    new NotasAluno { NotaAlunoId = 32, AlunoId = 8, CursoId = 2, DiciplinaId = 7, NotaDiciplina = 8.0M },
                    new NotasAluno { NotaAlunoId = 33, AlunoId = 8, CursoId = 2, DiciplinaId = 8, NotaDiciplina = 9.0M },
                    new NotasAluno { NotaAlunoId = 34, AlunoId = 8, CursoId = 2, DiciplinaId = 9, NotaDiciplina = 8.0M },
                    new NotasAluno { NotaAlunoId = 35, AlunoId = 8, CursoId = 2, DiciplinaId = 10, NotaDiciplina = 10.0M }

               );
        }
    }
}
