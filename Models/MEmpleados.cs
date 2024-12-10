using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Models
{
    public class MEmpleados
    {
        public List<Empleados> Listar()
        {
            List<Empleados> lista = new List<Empleados>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idempleado, documento, nombres, apellidos, c.idcargo, c.nombrecargo, h.idhorario, h.horainicio, h.horasalida from empleados ep");
                    query.AppendLine("inner join cargos c on c.idcargo = ep.idcargo");
                    query.AppendLine("inner join horarios h on h.idhorario = ep.idhorario");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Empleados()
                            {
                                idempleado = Convert.ToInt32(dr["idempleado"]),
                                documento = dr["documento"].ToString(),
                                nombres = dr["nombres"].ToString(),
                                apellidos = dr["apellidos"].ToString(),
                                oCargo = new Cargos() { idcargo = Convert.ToInt32(dr["idcargo"]), nombrecargo = dr["nombrecargo"].ToString() },
                                oHorario = new Horarios() { idhorario = Convert.ToInt32(dr["idhorario"]), horainicio = dr["horainicio"].ToString(), horasalida = dr["horasalida"].ToString() }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Empleados>();
                }
            }
            return lista;
        }

        public int Registrar(Empleados obj, out string Mensaje)
        {
            int idempleadogenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("spu_registrar_empleado", oconexion);
                    //cmd.Parameters.AddWithValue("idempleado", obj.idempleado);
                    cmd.Parameters.AddWithValue("documento", obj.documento);
                    cmd.Parameters.AddWithValue("nombres", obj.nombres);
                    cmd.Parameters.AddWithValue("apellidos", obj.apellidos);
                    cmd.Parameters.AddWithValue("idcargo", obj.oCargo.idcargo);
                    cmd.Parameters.AddWithValue("idhorario", obj.oHorario.idhorario);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idempleadogenerado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idempleadogenerado = 0;
                Mensaje = ex.Message;
            }
            return idempleadogenerado;
        }

        public bool Editar(Empleados obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("spu_editar_empleado", oconexion);
                    cmd.Parameters.AddWithValue("idempleado", obj.idempleado);
                    cmd.Parameters.AddWithValue("documento", obj.documento);
                    cmd.Parameters.AddWithValue("nombres", obj.nombres);
                    cmd.Parameters.AddWithValue("apellidos", obj.apellidos);
                    cmd.Parameters.AddWithValue("idcargo", obj.oCargo.idcargo);
                    cmd.Parameters.AddWithValue("idhorario", obj.oHorario.idhorario);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }

        public bool Eliminar(Empleados obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("spu_eliminar_empleado", oconexion);
                    cmd.Parameters.AddWithValue("idempleado", obj.idempleado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }
    }
}
