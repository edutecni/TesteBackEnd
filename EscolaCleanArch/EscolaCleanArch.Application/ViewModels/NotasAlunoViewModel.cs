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

        //[Required(ErrorMessage ="A nota da diciplina é obrigatória")]
        [Range(0, 10)]
        [DisplayName("Nota Diciplina")]
        public Decimal NotaDiciplina { get; set; }

        [Required(ErrorMessage = "O Id do Aluno é obrigatório")]        
        [DisplayName("Nota Diciplina")]
        public int AlunoId { get; set; }

        [Required(ErrorMessage = "O Id da Diciplina é obrigatória")]
        [DisplayName("Nota Diciplina")]
        public int DiciplinaId { get; set; }

        [Required(ErrorMessage = "O Id do Curso é obrigatório")]
        [DisplayName("Nota Diciplina")]
        public int CursoId { get; set; }

       
    }
}
