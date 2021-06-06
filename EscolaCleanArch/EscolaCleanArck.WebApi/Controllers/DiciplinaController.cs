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

        [HttpGet]
        public async Task<IEnumerable<DiciplinaViewModel>> GetDiciplinas()
        {
            var result = await _diciplinaService.GetDiciplinas();
            return result;
        }
    }
}
