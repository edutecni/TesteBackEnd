using EscolaCleanArch.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace EscolaClearArch.Domain.Tests
{
    public class AlunoTest1
    {
        // Por falta de tempo optei por aplicar os testes somente na classe Aluno.
        [Fact]
        public void CriarAluno_ComParametrosValidos_ResultadoValidaEstado()
        {
            Action action = () => new Aluno( 1, "Aluno Teste", "Manh�", "00001" , 1);
            action.Should().NotThrow<Exception>();
        }

        [Fact]
        public void CriarAluno_ComNomeVazio_DomainExceptionRequiredNomeObrigatorio()
        {
            Action action = () => new Aluno(string.Empty,  "00001", "Manh�", 1 );
            action.Should().Throw<EscolaCleanArch.Domain.Validation.DomainExceptionValidation>().WithMessage("O Nome do aluno � obrigat�rio");
        }

        [Fact]
        public void CriarAluno_ComRAVazio_DomainExceptionRequiredRAdoObrigatorio()
        {
            Action action = () => new Aluno("Aluno Teste", string.Empty, "Manh�", 1);
            action.Should().Throw<EscolaCleanArch.Domain.Validation.DomainExceptionValidation>().WithMessage("O RA do aluno � obrigat�rio");
        }

        [Fact]
        public void CriarAluno_ComPeriodoVazio_DomainExceptionRequiredPeriodoObrigatorio()
        {
            Action action = () => new Aluno("Aluno Teste", "00001", string.Empty,  1);
            action.Should().Throw<EscolaCleanArch.Domain.Validation.DomainExceptionValidation>().WithMessage("O Per�odo � obrigat�rio");
        }

        [Fact]
        public void CriarAluno_ComIdCursoVazio_DomainExceptionRequiredIdCursoObrigatorio()
        {
            Action action = () => new Aluno("Aluno Teste", "00001", "Manh�", int.MinValue);
            action.Should().Throw<EscolaCleanArch.Domain.Validation.DomainExceptionValidation>().WithMessage("O CursoId � obrigat�rio");
        }
    }
}
