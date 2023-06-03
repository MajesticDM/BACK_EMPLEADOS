using CORE.EMPLEADOS.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace INFRAESTRUCTURE.EMPLEADOS.Datos.Configuraciones
{
    public class SubAreasConfig : IEntityTypeConfiguration<SubAreas>
    {
        public void Configure(EntityTypeBuilder<SubAreas> builder)
        {
            builder.HasKey(e => e.IdSubArea)
                    .HasName("PK__SUB_AREA__7CBBE2F002F81B91");

            builder.ToTable("SUB_AREAS");

            builder.Property(e => e.IdSubArea)
                .HasColumnName("ID_SUB_AREA")
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Estado).HasColumnName("ESTADO");

            builder.Property(e => e.IdxArea)
                .HasColumnName("IDX_AREA")
                .HasColumnType("numeric(18, 0)");

            builder.Property(e => e.SubArea)
                .IsRequired()
                .HasColumnName("SUB_AREA")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(d => d.IdxAreaNavigation)
                .WithMany(p => p.SubAreas)
                .HasForeignKey(d => d.IdxArea)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SUB_AREAS__IDX_A__38996AB5");
        }
    }
}
