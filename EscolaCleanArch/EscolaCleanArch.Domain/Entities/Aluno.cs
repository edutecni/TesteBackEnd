using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Domain.Entities
{
    public class Aluno
    {
        [Key]
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public string RA { get; set; }
        public string Periodo { get; set; }
        public char Status { get; }
        public int? CursoId { get; set; }
        public byte[] Foto { get; set; }

        public Curso Curso { get; set; }
    }
    
}
