using CORE.EMPLEADOS.Interfaces;
using INFRAESTRUCTURE.EMPLEADOS.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace API.EMPLEADOS.Resolvers
{
    public static class Empleados_dependencias
    {
        public static void Empleados_dependenciasR(this IServiceCollection services)
        {
            services.AddTransient<IEmpleados, EmpleadosRepo>();
            services.AddTransient<ISubAreas,SubAreasRepo>();
            services.AddTransient<ITipoDocumentos, TipoDocumentosRepo>();
            services.AddTransient<ILogin, TokenRepo>();
        }
    }
}
