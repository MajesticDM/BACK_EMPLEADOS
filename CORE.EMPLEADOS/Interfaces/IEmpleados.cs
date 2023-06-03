using CORE.EMPLEADOS.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CORE.EMPLEADOS.Interfaces
{
    public interface IEmpleados
    {
        Task<IEnumerable<Empleados>> GetEmpleados();
        Task<Empleados> GetEmpleadosxId(int id);
        Task Post(Empleados empleado);
        Task<bool> Update(Empleados empleado);
        Task<bool> Delete(int id);
        Task<IEnumerable<CargaInicial>> SP_CARGAR_DATOS_EMPLEADOS();
    }
}
