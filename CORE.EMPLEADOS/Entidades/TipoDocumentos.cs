using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CORE.EMPLEADOS.Entidades
{
    public partial class TipoDocumentos
    {
        public TipoDocumentos()
        {
            Empleados = new HashSet<Empleados>();
        }

        public decimal IdTipoDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Empleados> Empleados { get; set; }
    }
}
