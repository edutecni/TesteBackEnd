using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Domain.Entities
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }
        public string Nome { get; set; }
        public Diciplina Diciplina { get; set; }
        //public Aluno Aluno { get; set; }
        public List<Diciplina> DiciplinasCurso { get; set; }
        public List<Aluno> AlunosCurso { get; set; }
    }
}
