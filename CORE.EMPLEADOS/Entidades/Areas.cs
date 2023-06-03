using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CORE.EMPLEADOS.Entidades
{
    public partial class Areas
    {
        public Areas()
        {
            SubAreas = new HashSet<SubAreas>();
        }

        public decimal IdArea { get; set; }
        public string Area { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<SubAreas> SubAreas { get; set; }
    }
}
