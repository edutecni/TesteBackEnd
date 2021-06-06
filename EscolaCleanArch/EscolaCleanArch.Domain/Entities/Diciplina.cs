using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Domain.Entities
{
    public class Diciplina
    {
        [Key]
        public int DiciplinaId{ get; set; }
        public string Nome { get; set; }
        public decimal NotaMinima { get; set; }
    }
}
