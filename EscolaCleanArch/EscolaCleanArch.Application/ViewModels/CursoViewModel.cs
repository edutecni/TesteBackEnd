using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Application.ViewModels
{
    public class CursoViewModel
    {
        public int CursoId { get; set; }

        [Required(ErrorMessage = "O nome da curso é obrigatório")]
        [MinLength(3)]
        [MaxLength(50)]
        [DisplayName("Nome")]
        public string Nome { get; set; }
        
    }
}
