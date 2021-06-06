using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Infra.Data.Models
{
    public class Diciplina
    {
        [Key]
        public int IdDiciplina { get; set; }
        public string Nome { get; set; }
        public decimal NotaMinima { get; set; }
    }
}
