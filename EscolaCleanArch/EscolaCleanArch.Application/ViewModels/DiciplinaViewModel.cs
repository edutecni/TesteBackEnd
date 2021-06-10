using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Application.ViewModels
{
    public class DiciplinaViewModel
    {
        public int DiciplinaId { get; set; }

        [Required(ErrorMessage = "O nome da diciplina é obrigatório")]
        [MinLength(3)]
        [MaxLength(50)]
        [DisplayName("Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="A nota minima é obrigatória")]
        [Range(0, 100)]
        [DisplayName("Nota Mínima")]
        public decimal NotaMinima { get; set; }
        public int CursoId { get; set; }
    }
}
