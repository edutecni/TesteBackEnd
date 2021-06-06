using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Infra.Data.Models
{
    public class NotaAluno
    {
        public int IdNotaAluno { get; set; }
        public Aluno Aluno { get; set; }
        public Curso Curso { get; set; }
        public Diciplina Diciplina { get; set; }        
        public Decimal NotaDiciplina { get; set; }
    }
}
