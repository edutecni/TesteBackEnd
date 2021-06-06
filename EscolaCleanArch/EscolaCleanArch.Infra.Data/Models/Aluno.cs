using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Infra.Data.Models
{
    public class Aluno
    {
        [Key]
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public string RA { get; set; }
        public string Periodo { get; set; }
        public char Status { get; }
        public byte[] Foto { get; set; }

        public Curso Curso { get; set; }
    }
    
}
