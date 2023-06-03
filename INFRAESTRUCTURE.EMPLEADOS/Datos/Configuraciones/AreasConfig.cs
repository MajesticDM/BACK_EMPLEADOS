using CORE.EMPLEADOS.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace INFRAESTRUCTURE.EMPLEADOS.Datos.Configuraciones
{
    public class AreasConfig : IEntityTypeConfiguration<Areas>
    {
       

        public void Configure(EntityTypeBuilder<Areas> builder)
        {
            builder.HasKey(e => e.IdArea)
                   .HasName("PK__AREAS__6E15A1AA3D7AF4CE");

            builder.ToTable("AREAS");

            builder.Property(e => e.IdArea)
                .HasColumnName("ID_AREA")
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Area)
                        .IsRequired()
                        .HasColumnName("AREA")
                        .HasMaxLength(50)
                        .IsUnicode(false);

            builder.Property(e => e.Estado).HasColumnName("ESTADO");
        }
    }
}
