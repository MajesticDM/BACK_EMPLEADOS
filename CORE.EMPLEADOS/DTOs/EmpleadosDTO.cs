using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CORE.EMPLEADOS.DTOs
{
    public partial class EmpleadosDTO
    {
        public decimal IdEmpleado { get; set; }
        public decimal? IdxSubArea { get; set; }
        public decimal? IdxTipoDocumento { get; set; }
        public string Documento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

    }
}
