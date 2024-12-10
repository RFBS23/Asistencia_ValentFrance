using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MAsistencia
    {
        public List<Asistencia> Listar(DateTime? fechaInicio = null, DateTime? fechaFin = null, int idEmpleado = 0)
        {
            List<Asistencia> lista = new List<Asistencia>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT idasistencia, em.documento, em.idempleado,");
                    query.AppendLine("em.nombres + ' ' + em.apellidos AS nombre_completo,");
                    query.AppendLine("FORMAT(asis.horaentrada, 'hh:mm tt') AS horaentrada,");
                    query.AppendLine("FORMAT(asis.horasalida, 'hh:mm tt') AS horasalida,");
                    query.AppendLine("horastrabajadas,");
                    query.AppendLine("CONVERT(VARCHAR(10), fecharegistro, 120) AS fecharegistro");
                    query.AppendLine("FROM asistencia asis");
                    query.AppendLine("INNER JOIN empleados em ON em.idempleado = asis.idempleado");

                    // Condiciones dinámicas
                    query.AppendLine("WHERE 1=1"); // Siempre true para agregar condiciones dinámicamente
                    if (fechaInicio.HasValue)
                    {
                        query.AppendLine("AND fecharegistro >= @fechaInicio");
                    }
                    if (fechaFin.HasValue)
                    {
                        query.AppendLine("AND fecharegistro <= @fechaFin");
                    }
                    if (idEmpleado > 0) // Filtrar solo si el idEmpleado es mayor a 0
                    {
                        query.AppendLine("AND em.idempleado = @idEmpleado");
                    }

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Agregar parámetros
                    if (fechaInicio.HasValue)
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.Value);
                    if (fechaFin.HasValue)
                        cmd.Parameters.AddWithValue("@fechaFin", fechaFin.Value);
                    if (idEmpleado > 0)
                        cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Asistencia
                            {
                                idasistencia = Convert.ToInt32(dr["idasistencia"]),
                                oEmpleados = new Empleados
                                {
                                    idempleado = Convert.ToInt32(dr["idempleado"]),
                                    documento = dr["documento"].ToString(),
                                    nombres = dr["nombre_completo"].ToString()
                                },
                                horaentrada = dr["horaentrada"].ToString(),
                                horasalida = dr["horasalida"].ToString(),
                                horastrabajadas = dr["horastrabajadas"].ToString(),
                                fecharegistro = dr["fecharegistro"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al listar asistencias: " + ex.Message);
                    throw;
                }
            }

            return lista;
        }

        public int Registrar(Asistencia obj, out string Mensaje)
        {
            int idasistenciagenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_registrar_asistencia", oconexion);
                    cmd.Parameters.AddWithValue("@documento", obj.oEmpleados.documento);

                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idasistenciagenerado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idasistenciagenerado = 0;
                Mensaje = ex.Message;
            }

            return idasistenciagenerado;
        }

        public DataTable ObtenerEmpleadosPorDia()
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_obtener_empleados_con_asistencias", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conexion.Open();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ObtenerEmpleadosPorMes()
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_obtener_empleados_por_mes", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conexion.Open();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
