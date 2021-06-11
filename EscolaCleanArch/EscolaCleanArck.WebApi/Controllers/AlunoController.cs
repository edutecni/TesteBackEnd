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
        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpGet("GetAlunos")]
        public async Task<IEnumerable<AlunoViewModel>> GetAlunos()
        {
            var result = await _alunoService.GetAlunos();
            return result;
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

            return aluno;
        }

        [HttpGet("GetByNome/{nome}")]
        public async Task<IEnumerable<AlunoViewModel>> GetByNome(string nome)
        {            
            var ltAluno = await _alunoService.GetAlunos();
            var aluno = ltAluno.Where(a => a.Nome.Contains(nome));

            return aluno;
        }

        [HttpGet("GetByRA/{ra}")]
        public async Task<AlunoViewModel> GetByRA(string ra)
        {
            var ltAluno = await _alunoService.GetAlunos();
            var aluno = ltAluno.Where(a => a.RA == ra).FirstOrDefault();

            return aluno;
        }

        [HttpGet("GetByCurso/{idCurso}")]
        public async Task<AlunoViewModel> GetByCurso(int? idCurso)
        {
            var ltAluno = await _alunoService.GetAlunos();
            var aluno = ltAluno.Where(a => a.CursoId == idCurso).FirstOrDefault();

            return aluno;
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
    }
}
