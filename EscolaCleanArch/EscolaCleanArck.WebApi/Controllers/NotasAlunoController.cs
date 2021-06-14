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
    public class NotasAlunoController : ControllerBase
    {
        private readonly INotasAlunoService _notasAlunoService;
        public NotasAlunoController(INotasAlunoService notasAlunoService)
        {
            _notasAlunoService = notasAlunoService;
        }

        [HttpGet("GetNotasAlunos")]
        public async Task<IEnumerable<NotasAlunoViewModel>> GetNotasAlunos()
        {
            var result = await _notasAlunoService.GetNotasAlunos();
            return result;
        }

        [HttpPost("Add")]        
        public void Add(NotasAlunoViewModel notasAluno)
        {
            if (ModelState.IsValid)
            {
                _notasAlunoService.Add(notasAluno);
            }            
        }

        [HttpGet("GetById/{id}")]
        public async Task<NotasAlunoViewModel> GetById(int? id)
        {
            var notasAluno = await _notasAlunoService.GetById(id);            

            return notasAluno;
        }

        [HttpGet("GetByAlunoId/{alunoId}")]
        public async Task<IEnumerable<NotasAlunoViewModel>> GetByAlunoId(int? alunoId)
        {
            var ltNotas = await _notasAlunoService.GetNotasAlunos();               

            if (alunoId > 0)
            {
                ltNotas = ltNotas.Where(n => n.AlunoId == alunoId);
                
            }            

            return ltNotas;
        }

        [HttpPost("Edit/{id}")]        
        public void Edit(int id, NotasAlunoViewModel notasAluno)
        {
            if (id > 0)
            {
                try
                {
                    _notasAlunoService.Update(notasAluno);
                }
                catch (Exception)
                {
                    throw;
                }
            }  
        }

        [HttpPost("Delete/{id}")]
        public void Delete(int id, NotasAlunoViewModel notasAluno)
        {
            if (id > 0)
            {
                try
                {
                    _notasAlunoService.Remove(notasAluno);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
