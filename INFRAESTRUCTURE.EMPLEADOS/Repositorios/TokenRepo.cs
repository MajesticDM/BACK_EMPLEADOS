using CORE.EMPLEADOS.Entidades;
using CORE.EMPLEADOS.Interfaces;
using INFRAESTRUCTURE.EMPLEADOS.Datos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE.EMPLEADOS.Repositorios
{
    public class TokenRepo : ILogin
    {
        private readonly EMPLEADOSContext _context;
        public TokenRepo(EMPLEADOSContext context)
        {
            _context = context;
        }

        public async Task<Usuarios> GetLoginByCredential(Login login)
        {
            Usuarios usuarios = await _context.Usuarios.FirstOrDefaultAsync(u => u.Usuario == login.usuario && u.Contraseña == login.contrasena);
            return usuarios;
        }
    }
}
