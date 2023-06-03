using AutoMapper;
using CORE.EMPLEADOS.DTOs;
using CORE.EMPLEADOS.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.EMPLEADOS.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SubAreasController : ControllerBase
    {
        private readonly ISubAreas _interfaz;
        public SubAreasController(ISubAreas interfaz)
        {
            _interfaz = interfaz;
        }

        [HttpGet]
        public async Task<IActionResult> getParametrosDrop()
        {
            var SubAreas = await _interfaz.GetSubAreas();
            return Ok(SubAreas);
        }
    }
}
