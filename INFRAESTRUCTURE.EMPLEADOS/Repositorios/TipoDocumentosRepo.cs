using CORE.EMPLEADOS.Entidades;
using CORE.EMPLEADOS.Interfaces;
using INFRAESTRUCTURE.EMPLEADOS.Datos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE.EMPLEADOS.Repositorios
{
    public class TipoDocumentosRepo :ITipoDocumentos
    {
        private readonly EMPLEADOSContext _context;
        public TipoDocumentosRepo(EMPLEADOSContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TipoDocumentos>> GetTipoDocumentos()
        {
            var TipoDocumentos = await _context.TipoDocumentos.ToListAsync();
            return TipoDocumentos;
        }
    }
}
