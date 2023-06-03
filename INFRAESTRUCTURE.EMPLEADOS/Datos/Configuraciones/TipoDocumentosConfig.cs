using CORE.EMPLEADOS.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace INFRAESTRUCTURE.EMPLEADOS.Datos.Configuraciones
{
    public class TipoDocumentosConfig : IEntityTypeConfiguration<TipoDocumentos>
    {
        public void Configure(EntityTypeBuilder<TipoDocumentos> builder)
        {
            builder.HasKey(e => e.IdTipoDocumento)
                    .HasName("PK__TIPO_DOC__844949287F87B5A1");

            builder.ToTable("TIPO_DOCUMENTOS");

            builder.Property(e => e.IdTipoDocumento)
                .HasColumnName("ID_TIPO_DOCUMENTO")
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Estado).HasColumnName("ESTADO");

            builder.Property(e => e.TipoDocumento)
                .IsRequired()
                .HasColumnName("TIPO_DOCUMENTO")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
