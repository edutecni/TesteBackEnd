using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Application.ViewModels
{
    public class NotasAlunoViewModel
    {
        public int NotasAlunoId { get; set; }        

        [Required(ErrorMessage ="A nota é obrigatória")]
        [Range(0, 10)]
        [DisplayName("Nota")]
        public decimal Nota { get; set; }
    }
}
