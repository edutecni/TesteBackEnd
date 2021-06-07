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
    [Route("api/[controller]")]
    [ApiController]
    public class DiciplinaController : ControllerBase
    {
        private readonly IDiciplinaService _diciplinaService;
        public DiciplinaController(IDiciplinaService diciplinaService)
        {
            _diciplinaService = diciplinaService;
        }

        //[HttpGet]
        //public async Task<DiciplinaViewModel> GetById(int? id)
        //{
        //    var result = await _diciplinaService.GetById(id);
        //    return result;
        //}

        [HttpGet]
        public async Task<IEnumerable<DiciplinaViewModel>> GetDiciplinas()
        {
            var result = await _diciplinaService.GetDiciplinas();
            return result;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void Add(DiciplinaViewModel diciplina)
        {
            if (ModelState.IsValid)
            {
                _diciplinaService.Add(diciplina);
            }            
        }

        [HttpGet("{id}")]
        public async Task<DiciplinaViewModel> GetById(int? id)
        {
            var diciplina = await _diciplinaService.GetById(id);

            if (diciplina == null)
            {
                throw new Exception("Diciplina não encontrada"); 
            }

            return diciplina;
        }

        [HttpPost("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public void Edit(int id, DiciplinaViewModel diciplina)
        {
            if (id !=  diciplina.DiciplinaId)
            {
                throw new Exception("Id inválido");
            }           
            
            try
            {
                _diciplinaService.Update(diciplina);                
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
