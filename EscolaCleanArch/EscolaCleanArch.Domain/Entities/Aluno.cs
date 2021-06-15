using EscolaCleanArch.Domain.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaCleanArch.Domain.Entities
{
    public sealed class Aluno
    {
        [Key]
        public int AlunoId { get; private set; }
        public string Nome { get; private set; }
        public string RA { get; private set; }
        public string Periodo { get; private set; }

        // Status somente leitura
        public string Status { get; }
        public int? CursoId { get; private set; }
        public byte[] Foto { get; private set; }

        //public Curso Curso { get; set; }
        //public  IEnumerable<NotasAluno> Notas { get; set; }

        public Aluno()
        {

        }

        // Utilizando-se do princípio do DDD onde a própria classe se testa e garante a sua integridade
        // Por falta de tempo optei por aplicar essa metodologia somente na classe Aluno.
        public Aluno(string nome, string ra, string periodo, int cursoId)
        {
            ValidateDomain(nome, ra, periodo);
            DomainExceptionValidation.When(cursoId < 0, "O CursoId é obrigatório");            
            CursoId = cursoId;
        }

        public Aluno(int alunoId, string nome, string ra, string periodo, int cursoId)
        {
            DomainExceptionValidation.When(alunoId < 0, "O AlunoId invalido");            
            DomainExceptionValidation.When(cursoId < 0, "O CursoId é obrigatório");
            ValidateDomain(nome, ra, periodo);
            AlunoId = alunoId;
            CursoId = cursoId;
        }

        private void ValidateDomain(string nome, string ra, string periodo)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome)   , "O Nome do aluno é obrigatório");
            DomainExceptionValidation.When(string.IsNullOrEmpty(ra), "O RA do aluno é obrigatório");
            DomainExceptionValidation.When(string.IsNullOrEmpty(periodo), "O Período é obrigatório");

            Nome = nome;
            RA = ra;
            Periodo = periodo;
        }


    }
    
}
