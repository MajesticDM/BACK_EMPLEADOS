using AutoMapper;
using CORE.EMPLEADOS.DTOs;
using CORE.EMPLEADOS.Entidades;
using CORE.EMPLEADOS.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.EMPLEADOS.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly IEmpleados _interfaz;
        private readonly IMapper _mapper;
        public EmpleadosController(IEmpleados interfaz, IMapper mapper)
        {
            _interfaz = interfaz;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Empleados = await _interfaz.GetEmpleados();
            var EmpleadosMap = _mapper.Map<IEnumerable<EmpleadosDTO>>(Empleados);
            return Ok(EmpleadosMap);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var Empleado = await _interfaz.GetEmpleadosxId(Id);
            if (Empleado == null)
            {
                return Ok(Empleado);
            }
            else
            {
                var EmpleadoMap = _mapper.Map<EmpleadosDTO>(Empleado);
                return Ok(EmpleadoMap);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Save(EmpleadosDTO DTOs)
        {
            var Empleado = _mapper.Map<Empleados>(DTOs);
            await _interfaz.Post(Empleado);
            return Ok(Empleado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int Id, EmpleadosDTO Empleado)
        {
            var EmpleadoUpd = _mapper.Map<Empleados>(Empleado);
            EmpleadoUpd.IdEmpleado = Id;
            await _interfaz.Update(EmpleadoUpd);
            return Ok(EmpleadoUpd);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            var Empleado = await _interfaz.Delete(Id);
            return Ok(Empleado);
        }

        [HttpGet("cargaInicial")]
        public async Task<IActionResult> getDatosIniciales()
        {
            var CargaInicial = await _interfaz.SP_CARGAR_DATOS_EMPLEADOS();
            return Ok(CargaInicial);
        }
    }
}
