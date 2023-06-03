using CORE.EMPLEADOS.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INFRAESTRUCTURE.EMPLEADOS.Datos.Configuraciones
{
    internal class UsuariosConfig : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            builder.HasKey(e => e.IdUsuario)
                    .HasName("PK__USUARIOS__91136B906ACF1E05");

            builder.ToTable("USUARIOS");

            builder.Property(e => e.IdUsuario)
                .HasColumnName("ID_USUARIO")
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Contraseña)
                .IsRequired()
                .HasColumnName("CONTRASEÑA")
                .IsUnicode(false);

            builder.Property(e => e.Estado).HasColumnName("ESTADO");

            builder.Property(e => e.Usuario)
                .IsRequired()
                .HasColumnName("USUARIO")
                .HasMaxLength(30);
        }
    }
}
