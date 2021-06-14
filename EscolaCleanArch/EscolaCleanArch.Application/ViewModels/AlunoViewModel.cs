using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Application.ViewModels
{
    public class AlunoViewModel
    {
        public int AlunoId { get; set; }

        // AlunoId = 1, Nome = "Eduardo Alves Canuto", Periodo = "Manhã", RA = "00001"

        [Required(ErrorMessage = "O nome da aluno é obrigatório")]
        [MinLength(3)]
        [MaxLength(50)]
        [DisplayName("Nome")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage ="O período é obrigatório")]        
        [DisplayName("Período")]
        public string Periodo { get; set; }

        [Required(ErrorMessage = "O RA é obrigatório")]
        [DisplayName("RA")]
        public string RA { get; set; }

        public int CursoId { get; set; }

        public string Status { get; set; }
        
        public CursoViewModel Curso { get; set; }
        public IEnumerable<NotasAlunoViewModel> Notas { get; set; }
    }
}
