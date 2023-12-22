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
    public class Datos_Estatus
    {
        public void Actualizar(EstatusAlumno estatus)
        {
            string query = $"SP_Actualizar_EstatusAlumno";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConection"].ToString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", estatus.id);
                    cmd.Parameters.AddWithValue("clave", estatus.clave);
                    cmd.Parameters.AddWithValue("nombre", estatus.nombre);
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

        public void Agregar(EstatusAlumno estatus)
        {
            string query = $"SP_Agregar_EstatusAlumno";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConection"].ToString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", estatus.id);
                    cmd.Parameters.AddWithValue("clave", estatus.clave);
                    cmd.Parameters.AddWithValue("nombre", estatus.nombre);
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

        public EstatusAlumno Consulta(int id)
        {
            EstatusAlumno estatusAlumno = new EstatusAlumno();
            string query = $"SP_ConsultarUNO_EstatusAlumno";
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

                    estatusAlumno.id = (int.Parse(dataReader["id"].ToString()));
                    estatusAlumno.clave = dataReader["clave"].ToString();
                    estatusAlumno.nombre = dataReader["Nombre"].ToString();
                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al consultar el registro" + e);
                }
            }
            return estatusAlumno;
        }

        public List<EstatusAlumno> Consultar()
        {
            List<EstatusAlumno> listaEstatus = new List<EstatusAlumno>();
            string query = $"SP_ConsultarTodo_EstatusAlumno";
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
                        EstatusAlumno estatus = new EstatusAlumno(int.Parse(dataReader["id"].ToString()), dataReader["clave"].ToString(), dataReader["Nombre"].ToString());
                        listaEstatus.Add(estatus);
                    }
                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al consultar los registros" + e);
                }
            }
            return listaEstatus;
        }

        public void Eliminar(int id)
        {
            string query = $"SP_Eliminar_EstatusAlumno";
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
