using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CORE.EMPLEADOS.DTOs
{
    public partial class SubAreasDTO
    {

        public decimal IdSubArea { get; set; }
        public decimal IdxArea { get; set; }
        public string SubArea { get; set; }
        public bool Estado { get; set; }
    }
}
