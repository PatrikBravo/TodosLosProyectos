using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Configuration;
using System.Data;

namespace Datos
{
    public class Datos_Alumnos
    {
        public void Actualizar(Alumno alumno)
        {
            string query = $"SP_Actualizar_Alumnos";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConection"].ToString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", alumno.id);
                    cmd.Parameters.AddWithValue("nombre", alumno.nombre);
                    cmd.Parameters.AddWithValue("primerApellido", alumno.primerApellido);
                    cmd.Parameters.AddWithValue("segundoApellido", alumno.segundoApellido);
                    cmd.Parameters.AddWithValue("correo", alumno.correo);
                    cmd.Parameters.AddWithValue("telefono", alumno.telefono);
                    cmd.Parameters.AddWithValue("fechaNacimiento", alumno.fechaNacimiento.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("curp", alumno.curp);
                    cmd.Parameters.AddWithValue("sueldo", alumno.sueldo);
                    cmd.Parameters.AddWithValue("idEstadoOrigen", alumno.idEstadoOrigen);
                    cmd.Parameters.AddWithValue("idEstatus", alumno.idEstatus);
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

        public void Agregar(Alumno alumno)
        {
            string query = $"SP_Agregar_Alumnos";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConection"].ToString()))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("nombre", alumno.nombre);
                    cmd.Parameters.AddWithValue("primerApellido", alumno.primerApellido);
                    cmd.Parameters.AddWithValue("segundoApellido", alumno.segundoApellido);
                    cmd.Parameters.AddWithValue("correo", alumno.correo);
                    cmd.Parameters.AddWithValue("telefono", alumno.telefono);
                    cmd.Parameters.AddWithValue("fechaNacimiento", alumno.fechaNacimiento);
                    cmd.Parameters.AddWithValue("curp", alumno.curp);
                    cmd.Parameters.AddWithValue("sueldo", alumno.sueldo);
                    cmd.Parameters.AddWithValue("idEstadoOrigen", alumno.idEstadoOrigen);
                    cmd.Parameters.AddWithValue("idEstatus", alumno.idEstatus);
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

        public Alumno Consulta(int id)
        {
            Alumno alumno = new Alumno();
            string query = $"SP_ConsultarUNO_Alumnos";
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

                    alumno.id = (int.Parse(dataReader["id"].ToString()));
                    alumno.nombre = dataReader["Nombre"].ToString();
                    alumno.primerApellido = dataReader["primerApellido"].ToString();
                    alumno.segundoApellido = dataReader["segundoApellido"].ToString();
                    alumno.correo = dataReader["correo"].ToString();
                    alumno.telefono = dataReader["telefono"].ToString();
                    alumno.fechaNacimiento = DateTime.Parse(dataReader["fechaNacimiento"].ToString());
                    alumno.curp = dataReader["curp"].ToString();
                    alumno.sueldo = decimal.Parse(dataReader["sueldo"].ToString());
                    alumno.idEstadoOrigen = int.Parse(dataReader["idEstadoOrigen"].ToString());
                    alumno.idEstatus = int.Parse(dataReader["idEstatus"].ToString());
                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al consultar el registro" + e);
                }
            }
            return alumno;
        }

        public List<Alumno> Consultar()
        {
            List<Alumno> listaAlumno = new List<Alumno>();
            string query = $"SP_ConsultarTodo_Alumnos";
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
                        Alumno alumno = new Alumno(int.Parse(dataReader["id"].ToString()), dataReader["Nombre"].ToString(),
                            dataReader["primerApellido"].ToString(), dataReader["segundoApellido"].ToString(), dataReader["correo"].ToString(),
                            dataReader["telefono"].ToString(), DateTime.Parse(dataReader["fechaNacimiento"].ToString()), dataReader["curp"].ToString(),
                            decimal.Parse(dataReader["sueldo"].ToString()), int.Parse(dataReader["idEstadoOrigen"].ToString()), int.Parse(dataReader["idEstatus"].ToString()));
                        listaAlumno.Add(alumno);
                    }
                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al consultar los registros" + e);
                }
            }
            return listaAlumno;
        }

        public void Eliminar(int id)
        {
            string query = $"SP_Eliminar_Alumnos";
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

        public List<ItemTablaISR> ConsultarTablaISR()
        {
            List<ItemTablaISR> itemisr = new List<ItemTablaISR>();

            string query = $"select * from TablaISR";
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
                        ItemTablaISR isr = new ItemTablaISR(decimal.Parse(dataReader["LimInf"].ToString()),
                            decimal.Parse(dataReader["LimSup"].ToString()), decimal.Parse(dataReader["CuotaFija"].ToString()), 
                            decimal.Parse(dataReader["ExedLimInf"].ToString()), decimal.Parse(dataReader["Subsidio"].ToString()),0);
                        itemisr.Add(isr);
                    }
                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al consultar los registros isr" + e);
                }
            }

            return itemisr;
        }
    }
}
