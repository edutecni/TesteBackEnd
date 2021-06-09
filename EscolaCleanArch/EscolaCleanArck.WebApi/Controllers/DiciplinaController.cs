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
    public class DiciplinaController : ControllerBase
    {
        private readonly IDiciplinaService _diciplinaService;
        public DiciplinaController(IDiciplinaService diciplinaService)
        {
            _diciplinaService = diciplinaService;
        }

        [HttpGet("GetDiciplinas")]
        public async Task<IEnumerable<DiciplinaViewModel>> GetDiciplinas()
        {
            var result = await _diciplinaService.GetDiciplinas();
            return result;
        }

        [HttpPost("Add")]        
        public void Add(DiciplinaViewModel diciplina)
        {
            if (ModelState.IsValid)
            {
                _diciplinaService.Add(diciplina);
            }            
        }

        [HttpGet("GetById/{id}")]
        public async Task<DiciplinaViewModel> GetById(int? id)
        {
            var diciplina = await _diciplinaService.GetById(id);            

            return diciplina;
        }

        [HttpPost("Edit/{id}")]        
        public void Edit(int id, DiciplinaViewModel diciplina)
        {
            if (id > 0)
            {
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

        [HttpPost("Delete/{id}")]
        public void Delete(int id, DiciplinaViewModel diciplina)
        {
            if (id > 0)
            {
                try
                {
                    _diciplinaService.Remove(diciplina);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
