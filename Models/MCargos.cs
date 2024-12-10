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
    public class MCargos
    {
        public List<Cargos> Listar()
        {
            List<Cargos> lista = new List<Cargos>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select  idcargo, nombrecargo, estado, CONVERT(VARCHAR(10), fecharegistro, 120)AS fecharegistro_cargo from cargos");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cargos()
                            {
                                idcargo = Convert.ToInt32(dr["idcargo"]),
                                nombrecargo = dr["nombrecargo"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]),
                                fecharegistro = dr["fecharegistro_cargo"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Cargos>();
                }
            }
            return lista;
        }

        public int Registrar(Cargos obj, out string Mensaje)
        {
            int idcargogenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("spu_registrar_cargos", oconexion);

                    cmd.Parameters.AddWithValue("nombrecargo", obj.nombrecargo);
                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idcargogenerado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idcargogenerado = 0;
                Mensaje = ex.Message;
            }
            return idcargogenerado;
        }

        public bool Editar(Cargos obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("spu_editar_cargos", oconexion);
                    cmd.Parameters.AddWithValue("idcargo", obj.idcargo);
                    cmd.Parameters.AddWithValue("nombrecargo", obj.nombrecargo);
                    cmd.Parameters.AddWithValue("estado", obj.estado);
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

        public bool Eliminar(Cargos obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("spu_eliminar_cargos", oconexion);
                    cmd.Parameters.AddWithValue("idcargo", obj.idcargo);
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

        public List<Cargos> ListarCargos()
        {
            List<Cargos> lista = new List<Cargos>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select  idcargo, nombrecargo, estado, CONVERT(VARCHAR(10), fecharegistro, 120)AS fecharegistro_cargo from cargos");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cargos()
                            {
                                idcargo = Convert.ToInt32(dr["idcargo"]),
                                nombrecargo = dr["nombrecargo"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]),
                                fecharegistro = dr["fecharegistro_cargo"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Cargos>();
                }
            }
            return lista;
        }

    }
}
