using EscolaCleanArch.Application.Interfaces;
using EscolaCleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaCleanArck.WebApi.Controllers
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
