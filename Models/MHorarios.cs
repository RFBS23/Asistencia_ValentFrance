using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MHorarios
    {
        public List<Horarios> Listar()
        {
            List<Horarios> lista = new List<Horarios>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idhorario, c.idcargo, c.nombrecargo, horainicio, horasalida from horarios h");
                    query.AppendLine("inner join cargos c on c.idcargo = h.idcargo");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Horarios()
                            {
                                idhorario = Convert.ToInt32(dr["idcargo"]),
                                oCargo = new Cargos() { idcargo = Convert.ToInt32(dr["idcargo"]), nombrecargo = dr["nombrecargo"].ToString() },
                                horainicio = dr["horainicio"].ToString(),
                                horasalida = dr["horasalida"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Horarios>();
                }
            }
            return lista;
        }

        public int Registrar(Horarios obj, out string Mensaje)
        {
            int idhorariogenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("spu_registrar_horario", oconexion);
                    cmd.Parameters.AddWithValue("idcargo", obj.oCargo.idcargo);
                    cmd.Parameters.AddWithValue("horainicio", obj.horainicio);
                    cmd.Parameters.AddWithValue("horasalida", obj.horasalida);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idhorariogenerado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idhorariogenerado = 0;
                Mensaje = ex.Message;
            }
            return idhorariogenerado;
        }

        public bool Editar(Horarios obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("spu_editar_horarios", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("idhorario", obj.idhorario);
                    cmd.Parameters.AddWithValue("idcargo", obj.oCargo.idcargo);
                    cmd.Parameters.AddWithValue("horainicio", obj.horainicio);
                    cmd.Parameters.AddWithValue("horasalida", obj.horasalida);

                    cmd.Parameters.Add("resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                //Mensaje = ex.Message;
                Mensaje = $"Error: {ex.Message}";
            }
            return respuesta;
        }

        public bool Eliminar(Horarios obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("spu_eliminar_tallasropa", oconexion);
                    cmd.Parameters.AddWithValue("idtallaropa", obj.idhorario);
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

        public List<Horarios> FiltrosHorarios(int idcargo)
        {
            List<Horarios> lista = new List<Horarios>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idhorario, c.idcargo, c.nombrecargo, horainicio, horasalida from horarios h");
                    query.AppendLine("inner join cargos c on c.idcargo = h.idcargo");
                    query.AppendLine("where c.idcargo = @idcargo");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idcargo", idcargo);
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Horarios()
                            {
                                idhorario = Convert.ToInt32(dr["idhorario"]),
                                horainicio = dr["horainicio"].ToString(),
                                horasalida = dr["horasalida"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Horarios>();
                }
            }
            return lista;
        }

    }
}
