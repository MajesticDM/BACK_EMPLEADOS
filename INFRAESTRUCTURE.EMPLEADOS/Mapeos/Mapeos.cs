using AutoMapper;
using CORE.EMPLEADOS.DTOs;
using CORE.EMPLEADOS.Entidades;

namespace INFRAESTRUCTURE.EMPLEADOS.Mapeos
{
    public class Mapeos : Profile
    {
        public Mapeos()
        {
            CreateMap<Empleados, EmpleadosDTO>();
            CreateMap<EmpleadosDTO, Empleados>();

            CreateMap<Areas, AreasDTO>();
            CreateMap<AreasDTO, Areas>();

            CreateMap<SubAreas, SubAreasDTO>();
            CreateMap<SubAreasDTO, SubAreas>();

            CreateMap<TipoDocumentos, TipoDocumentosDTO>();
            CreateMap<TipoDocumentosDTO, TipoDocumentos>();
        }
    }
}
