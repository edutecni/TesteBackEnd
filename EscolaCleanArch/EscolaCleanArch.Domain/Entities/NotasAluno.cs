using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Domain.Entities
{
    public class NotasAluno
    {
        [Key]
        public int NotaAlunoId { get; set; }

        public int AlunoId { get; set; }

        public int DiciplinaId { get; set; }

        public int CursoId { get; set; }

        public Decimal NotaDiciplina { get; set; }

        //public Aluno Aluno { get; set; }
        //public Curso Curso { get; set; }
        //public Diciplina Diciplina { get; set; }
    }
}
