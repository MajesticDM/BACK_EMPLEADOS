using CORE.EMPLEADOS.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.EMPLEADOS.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDocumentoController : ControllerBase
    {
        private readonly ITipoDocumentos _interfaz;
        public TipoDocumentoController(ITipoDocumentos interfaz)
        {
            _interfaz = interfaz;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var tipoDocumentos = await _interfaz.GetTipoDocumentos();
            return Ok(tipoDocumentos);
        }
    }
}
