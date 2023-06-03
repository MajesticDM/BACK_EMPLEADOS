using CORE.EMPLEADOS.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CORE.EMPLEADOS.Interfaces
{
    public interface ISubAreas
    {
        Task<IEnumerable<SubAreas>> GetSubAreas();
    }
}
