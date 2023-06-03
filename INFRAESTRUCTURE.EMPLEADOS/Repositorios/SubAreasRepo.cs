using CORE.EMPLEADOS.Entidades;
using CORE.EMPLEADOS.Interfaces;
using INFRAESTRUCTURE.EMPLEADOS.Datos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE.EMPLEADOS.Repositorios
{
    public  class SubAreasRepo : ISubAreas
    {
        private readonly EMPLEADOSContext _context;
        public SubAreasRepo(EMPLEADOSContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SubAreas>> GetSubAreas()
        {
            var SubAreas = await _context.SubAreas.ToListAsync();
            return SubAreas;
        }
    }
}
