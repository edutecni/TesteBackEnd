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
    public class CursoController : ControllerBase
    {
        private readonly ICursoService _cursoService;
        public CursoController(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }

        [HttpGet("GetCursos")]
        public async Task<IEnumerable<CursoViewModel>> GetCursos()
        {
            var result = await _cursoService.GetCursos();
            return result;
        }

        [HttpPost("Add")]        
        public void Add(CursoViewModel curso)
        {
            if (ModelState.IsValid)
            {
                _cursoService.Add(curso);
            }            
        }

        [HttpGet("GetById/{id}")]
        public async Task<CursoViewModel> GetById(int? id)
        {
            var curso = await _cursoService.GetById(id);            

            return curso;
        }

        [HttpPost("Edit/{id}")]        
        public void Edit(int id, CursoViewModel curso)
        {
            if (id > 0)
            {
                try
                {
                    _cursoService.Update(curso);
                }
                catch (Exception)
                {
                    throw;
                }
            }  
        }

        [HttpPost("Delete/{id}")]
        public void Delete(int id, CursoViewModel curso)
        {
            if (id > 0)
            {
                try
                {
                    
                    curso.CursoId = id;                    
                    _cursoService.Remove(curso);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
