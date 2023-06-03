using CORE.EMPLEADOS.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace INFRAESTRUCTURE.EMPLEADOS.Datos.Configuraciones
{
    public class EmpleadosConfig : IEntityTypeConfiguration<Empleados>
    {
        public void Configure(EntityTypeBuilder<Empleados> builder)
        {
            builder.HasKey(e => e.IdEmpleado)
                    .HasName("PK__EMPLEADO__922CA26998297FB2");

            builder.ToTable("EMPLEADOS");

            builder.Property(e => e.IdEmpleado)
                .HasColumnName("ID_EMPLEADO")
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Apellidos)
                .IsRequired()
                .HasColumnName("APELLIDOS")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Documento)
                .IsRequired()
                .HasColumnName("DOCUMENTO")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.IdxSubArea)
                .HasColumnName("IDX_SUB_AREA")
                .HasColumnType("numeric(18, 0)");

            builder.Property(e => e.IdxTipoDocumento)
                .HasColumnName("IDX_TIPO_DOCUMENTO")
                .HasColumnType("numeric(18, 0)");

            builder.Property(e => e.Nombres)
                .IsRequired()
                .HasColumnName("NOMBRES")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(d => d.IdxSubAreaNavigation)
                .WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdxSubArea)
                .HasConstraintName("FK__EMPLEADOS__IDX_S__3D5E1FD2");

            builder.HasOne(d => d.IdxTipoDocumentoNavigation)
                .WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdxTipoDocumento)
                .HasConstraintName("FK__EMPLEADOS__IDX_T__3E52440B");
        }
    }
}
