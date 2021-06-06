using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Infra.Data.Models
{
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }
        public string Nome { get; set; }        
        public List<Diciplina> DiciplinasCurso { get; set; }
        public List<Aluno> AlunosCurso { get; set; }
    }
}
