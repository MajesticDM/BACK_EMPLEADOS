using CORE.EMPLEADOS.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CORE.EMPLEADOS.Interfaces
{
    public interface ILogin
    {
        Task<Usuarios> GetLoginByCredential(Login login);
    }
}
