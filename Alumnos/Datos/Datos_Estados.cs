using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Entidades;

namespace Datos
{
    public class Datos_Estados
    {
        public void Actualizar(Estado estado)
        {
            string query = $"SP_Actualizar_Estado";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConection"].ToString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", estado.id);
                    cmd.Parameters.AddWithValue("nombre", estado.nombre);
                    con.Open();
                    cmd.ExecuteScalar();
                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al modificar el registro" + e);
                }
            }
        }

        public void Agregar(Estado estado)
        {
            string query = $"SP_Agregar_Estado";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConection"].ToString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", estado.id);
                    cmd.Parameters.AddWithValue("nombre", estado.nombre);
                    con.Open();
                    cmd.ExecuteScalar();
                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al agregar el registro" + e);
                }
            }
        }

        public Estado Consulta(int id)
        {
            Estado estado = new Estado();
            string query = $"SP_ConsultarUNO_Estado";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConection"].ToString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", id);
                    con.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();

                    estado.id = (int.Parse(dataReader["id"].ToString()));
                    estado.nombre = dataReader["Nombre"].ToString();
                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al consultar el registro" + e);
                }
            }
            return estado;
        }

        public List<Estado> Consultar()
        {
            List<Estado> listaEstados = new List<Estado>();
            string query = $"SP_ConsultarTodo_Estado";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConection"].ToString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Estado estado = new Estado(int.Parse(dataReader["id"].ToString()), dataReader["Nombre"].ToString());
                        listaEstados.Add(estado);
                    }
                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al consultar los registros" + e);
                }
            }
            return listaEstados;
        }

        public void Eliminar(int id)
        {
            string query = $"SP_Eliminar_Estado";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConection"].ToString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", id);
                    con.Open();
                    cmd.ExecuteScalar();
                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al borra registro" + e);
                }
            }
        }
    }
}
