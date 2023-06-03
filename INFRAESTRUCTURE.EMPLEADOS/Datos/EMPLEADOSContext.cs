using System;
using System.Reflection;
using CORE.EMPLEADOS.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace INFRAESTRUCTURE.EMPLEADOS.Datos
{
    public partial class EMPLEADOSContext : DbContext
    {
        public EMPLEADOSContext()
        {
        }

        public EMPLEADOSContext(DbContextOptions<EMPLEADOSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Areas> Areas { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<SubAreas> SubAreas { get; set; }
        public virtual DbSet<TipoDocumentos> TipoDocumentos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
