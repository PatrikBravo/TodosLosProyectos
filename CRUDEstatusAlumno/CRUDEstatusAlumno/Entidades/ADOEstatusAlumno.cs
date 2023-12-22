using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDEstatusAlumno.Entidades
{
    public class ADOEstatusAlumno : ICRUD
    {
        public void Actualizar(Estatus status)
        {
            string query = $"UPDATE EstatusAlumno set Clave='{status.clave}', Nombre='{status.nombre}' WHERE id={status.id}";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConection"].ToString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
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

        public int Agregar(Estatus status)
        {
            int id = -1;
            string query = $"insert into EstatusAlumno(id,Clave,Nombre) VALUES ({status.id},'{status.clave}','{status.nombre}')";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConection"].ToString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.ExecuteScalar();
                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al agregar el registro" + e);
                }
            }
            return id;
        }

        public Estatus Consulta(int id)
        {
            Estatus estatus = new Estatus();
            string query = $"select * from EstatusAlumno where id ={id}";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConection"].ToString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();

                    estatus.id = (int.Parse(dataReader["id"].ToString()));
                    estatus.clave = dataReader["clave"].ToString();
                    estatus.nombre = dataReader["Nombre"].ToString();
                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al consultar el registro" + e);
                }
            }
            return estatus;
        }

        public List<Estatus> Consultar()
        {
            List<Estatus> listaEstatud = new List<Estatus>();
            string query = $"select * from EstatusAlumno";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConection"].ToString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Estatus estatus = new Estatus(int.Parse(dataReader["id"].ToString()), dataReader["clave"].ToString(), dataReader["Nombre"].ToString());
                        listaEstatud.Add(estatus);
                    }
                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al consultar los registros" + e);
                }
            }
            return listaEstatud;
        }

        public void Eliminar(int id)
        {
            string query = $"delete EstatusAlumno where id={id}";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConection"].ToString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
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