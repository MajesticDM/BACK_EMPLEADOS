using CORE.EMPLEADOS.Entidades;
using CORE.EMPLEADOS.Interfaces;
using INFRAESTRUCTURE.EMPLEADOS.Datos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE.EMPLEADOS.Repositorios
{
    public class EmpleadosRepo : IEmpleados
    {
        private readonly EMPLEADOSContext _context;
        public EmpleadosRepo(EMPLEADOSContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Empleados>> GetEmpleados()
        {
            var Empleados = await _context.Empleados.ToListAsync();
            return Empleados;
        }
        public async Task<Empleados> GetEmpleadosxId(int id)
        {
            var Empleado = await _context.Empleados.FirstOrDefaultAsync(e => e.IdEmpleado == id);
            return Empleado;
        }
        public async Task Post(Empleados empleado)
        {
            _context.Add(empleado);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> Update(Empleados empleado)
        {
            var datos = await GetEmpleadosxId((int)empleado.IdEmpleado);
            datos.IdxSubArea = empleado.IdxSubArea;
            datos.IdxTipoDocumento = empleado.IdxTipoDocumento;
            datos.Documento = empleado.Documento;
            datos.IdEmpleado = empleado.IdEmpleado;
            datos.Nombres = empleado.Nombres;
            datos.Apellidos = empleado.Apellidos;

            int filas = await _context.SaveChangesAsync();
            return filas > 0;
        }
        public async Task<bool> Delete(int id)
        {
            var Eliminar = await GetEmpleadosxId(id);
            _context.Empleados.Remove(Eliminar);

            int filas = await _context.SaveChangesAsync();
            return filas > 0;
        }

        //Este proceso de almacenado es para cargar los datos iniciales de la tabla de inicio

        public async Task<IEnumerable<CargaInicial>> SP_CARGAR_DATOS_EMPLEADOS()
        {
            using (SqlConnection sql = new SqlConnection(_context.Database.GetDbConnection().ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_CARGAR_DATOS_EMPLEADOS", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        await sql.OpenAsync();
                        var List = new List<CargaInicial>();

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            { List.Add(RecorredDatos(reader)); }
                        }
                        return List;
                    }
                    catch (Exception ex)
                    {
                        string msg = ex.Message;
                        throw new Exception("Error al obtener Dato" + msg);
                    }
                    finally
                    {
                        if (sql.State == ConnectionState.Open)
                        { sql.Close(); }
                    }
                }
            }
        }

        private CargaInicial RecorredDatos(SqlDataReader reader)
        {
            return new CargaInicial()
            {
                IdEmpleado = Convert.ToDecimal(reader["ID_EMPLEADO"]),
                IdxSubArea = Convert.ToDecimal(reader["ID_SUB_AREA"]),
                idxTipoDocumento = Convert.ToDecimal(reader["ID_TIPO_DOCUMENTO"]),
                Area = Convert.ToString(reader["AREA"]),
                SubArea = Convert.ToString(reader["SUB_AREA"]),
                TipoDocumento = Convert.ToString(reader["TIPO_DOCUMENTO"]),
                Documento = Convert.ToString(reader["DOCUMENTO"]),
                Nombres = Convert.ToString(reader["NOMBRES"]),
                Apellidos= Convert.ToString(reader["APELLIDOS"])
            };
        }

    }
}
