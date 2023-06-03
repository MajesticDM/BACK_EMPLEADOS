using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CORE.EMPLEADOS.Entidades
{
    public partial class Usuarios
    {
        public decimal IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public bool? Estado { get; set; }
    }
}
