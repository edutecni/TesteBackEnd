using EscolaCleanArch.Application.Interfaces;
using EscolaCleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaCleanArch.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;
        private readonly ICursoService _cursoService;
        private readonly INotasAlunoService _notasAlunoService;
        public AlunoController(IAlunoService alunoService, ICursoService cursoService, INotasAlunoService notasAlunoService)
        {
            _alunoService = alunoService;
            _cursoService = cursoService;
            _notasAlunoService = notasAlunoService; ;
        }

        [HttpGet("GetAlunos")]
        public async Task<IEnumerable<AlunoViewModel>> GetAlunos()
        {
            var ltAlunos = await _alunoService.GetAlunos();
            
            return ltAlunos;
        }

        [HttpPost("Add")]        
        public void Add(AlunoViewModel aluno)
        {
            if (ModelState.IsValid)
            {
                _alunoService.Add(aluno);
            }            
        }

        [HttpGet("GetById/{id}")]
        public async Task<AlunoViewModel> GetById(int? id)
        {
            var aluno = await _alunoService.GetById(id);             
            aluno.Curso = await _cursoService.GetById(aluno.CursoId);           
            
            aluno.Notas = GetByAlunoId(aluno.CursoId);

            foreach (var nota in aluno.Notas)
            {
                if (nota != null && nota.NotaDiciplina < 7 )                
                    aluno.Status = "Reprovado";
                else
                    aluno.Status = "Aprovado";
            }

            return aluno;
        }

        [HttpGet("GetByNome/{nome}")]
        public async Task<IEnumerable<AlunoViewModel>> GetByNome(string nome)
        {
            var ltAlunos = _alunoService.GetAlunos().Result.Where(a => a.Nome.Contains(nome));            

            // Popula Cursos e Notas
            foreach (var aluno in ltAlunos)
            {
                aluno.Curso = await _cursoService.GetById(aluno.CursoId);
                aluno.Notas = (IEnumerable<NotasAlunoViewModel>)(GetByAlunoId(aluno.CursoId));

                aluno.Notas = GetByAlunoId(aluno.CursoId); 
                
                foreach (var nota in aluno.Notas)
                {
                    if (nota.NotaDiciplina > -1 && nota.NotaDiciplina < 7)
                    {
                        aluno.Status = "Reprovado";
                        break;
                    }
                    else if (nota.NotaDiciplina >= 7)
                        aluno.Status = "Aprovado";
                }

            }

            return ltAlunos;
        }

        [HttpGet("GetByRA/{ra}")]
        public async Task<AlunoViewModel> GetByRA(string ra)
        {
            var aluno =  _alunoService.GetAlunos().Result.Where(a => a.RA == ra).FirstOrDefault();
            aluno.Curso = await _cursoService.GetById(aluno.CursoId);

            aluno.Notas = GetByAlunoId(aluno.CursoId);

            foreach (var nota in aluno.Notas)
            {
                if (nota.NotaDiciplina > -1 && nota.NotaDiciplina < 7)
                {
                    aluno.Status = "Reprovado";
                    break;
                }
                else if (nota.NotaDiciplina >= 7)
                    aluno.Status = "Aprovado";
            }

            return aluno;
        }

        [HttpGet("GetByCurso/{idCurso}")]
        public async Task<IEnumerable<AlunoViewModel>> GetByCurso(int? idCurso)
        {
            var ltAlunos =  _alunoService.GetAlunos().Result.Where(a => a.CursoId == idCurso);

            // Popula Cursos
            foreach (var aluno in ltAlunos)
            {
                aluno.Curso = await _cursoService.GetById(aluno.CursoId);
                aluno.Notas = GetByAlunoId(aluno.CursoId);

                foreach (var nota in aluno.Notas)
                {
                    if (nota.NotaDiciplina > -1 && nota.NotaDiciplina < 7)
                    {
                        aluno.Status = "Reprovado";
                        break;
                    }
                    else if (nota.NotaDiciplina >= 7)
                        aluno.Status = "Aprovado";
                }
            }

            return ltAlunos;
        }

        [HttpPost("Edit/{id}")]        
        public void Edit(int id, AlunoViewModel aluno)
        {
            if (id > 0)
            {
                try
                {
                    _alunoService.Update(aluno);
                }
                catch (Exception)
                {
                    throw;
                }
            }  
        }

        [HttpPost("Delete/{id}")]
        public void Delete(int id, AlunoViewModel aluno)
        {
            if (id > 0)
            {
                try
                {
                    _alunoService.Remove(aluno);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private IEnumerable<NotasAlunoViewModel> GetByAlunoId(int? alunoId)
        {
            var ltNotas = _notasAlunoService.GetNotasAlunos();
            IEnumerable<NotasAlunoViewModel> resultado = null;

            if (alunoId > 0)
            {
                var ltNotasDoAluno = ltNotas.Result.Where(n => n.AlunoId == (int)alunoId);
                resultado = (IEnumerable<NotasAlunoViewModel>)ltNotasDoAluno;
            }

            return resultado;
        }
    }
}
