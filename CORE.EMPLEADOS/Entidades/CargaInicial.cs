using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.EMPLEADOS.Entidades
{
    public  class CargaInicial
    {
        public decimal IdEmpleado { get; set; }
        public decimal IdxSubArea { get; set; }
        public decimal idxTipoDocumento { get; set; }
        public  string Area { get; set; }
        public  string SubArea{ get; set; }
        public  string TipoDocumento { get; set; }
        public string Documento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
    }
}
