using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using Newtonsoft.Json;

namespace Negocio
{
    public class Negocio_Alumno
    {
        Datos_Alumnos Datos_Alumnos = new Datos_Alumnos();
        public void Actualizar(Alumno alumno)
        {
            Datos_Alumnos.Actualizar(alumno);
        }

        public void Agregar(Alumno alumno)
        {
            Datos_Alumnos.Agregar(alumno);
        }

        public Alumno Consulta(int id)
        {
            Alumno alumno = new Alumno();
            alumno = Datos_Alumnos.Consulta(id);
            return alumno;
        }

        public List<Alumno> Consultar()
        {
            List<Alumno> listaAlumno = new List<Alumno>();
            listaAlumno = Datos_Alumnos.Consultar();
            return listaAlumno;
        }

        public void Eliminar(int id)
        {
            Datos_Alumnos.Eliminar(id);
        }

        public ItemTablaISR CalcularISR(int id)
        {
            ItemTablaISR isr = new ItemTablaISR();
            try
            {
                Negocio.refWSAlumnos.AlumnosWSSoapClient aws = new Negocio.refWSAlumnos.AlumnosWSSoapClient();
                Negocio.refWSAlumnos.ItemTablaISR item = aws.CalcularISR(id);
                string json = JsonConvert.SerializeObject(item);
                isr = JsonConvert.DeserializeObject<ItemTablaISR>(json);
            }
            catch
            {
                decimal quincenal, sueldoMensual;
                Alumno alum = Datos_Alumnos.Consulta(id);
                sueldoMensual = alum.sueldo;
                quincenal = sueldoMensual / 2;

                List<ItemTablaISR> listaISR = new List<ItemTablaISR>();
                
                listaISR = Datos_Alumnos.ConsultarTablaISR();

                var datos = from info in listaISR where info.Límite_inferior < quincenal && quincenal < info.Límite_superior
                            select info;
                foreach (var isrIn in datos)
                {
                    isr.Límite_inferior = isrIn.Límite_inferior;
                    isr.Límite_superior = isrIn.Límite_superior;
                    isr.CuotaFija = isrIn.CuotaFija;
                    isr.Excedente = isrIn.Excedente;
                    isr.Subsidio = isrIn.Subsidio;
                    isr.ISR = (((quincenal - isrIn.Límite_inferior) * isrIn.Excedente) / 100m) + isrIn.CuotaFija + isrIn.Subsidio;
                }
            }
            return isr;
        }

        public AportacionesIMSS CalcularIMSS(int id)
        {
            AportacionesIMSS aportaciones = new AportacionesIMSS();

            try
            {
                Negocio.refWSAlumnos.AlumnosWSSoapClient aws = new Negocio.refWSAlumnos.AlumnosWSSoapClient();
                Negocio.refWSAlumnos.AportacionesIMSS item = aws.CalcularIMSS(id);
                string json = JsonConvert.SerializeObject(item);
                aportaciones = JsonConvert.DeserializeObject<AportacionesIMSS>(json);
            }
            catch
            {
                Alumno alum = Datos_Alumnos.Consulta(id);
                decimal sbc = alum.sueldo;
                decimal uma = Convert.ToDecimal(ConfigurationManager.AppSettings["uma"]);
                bool esPatron = false;

                

                decimal sbc1 = sbc - (3 * uma);
                aportaciones.EnfermedadMaternidad = esPatron ? 0.001m * sbc1 : 0.004m * sbc1;
                aportaciones.InvalidezVida = esPatron ? 0.00175m * sbc : 0.00625m * sbc;
                aportaciones.Retiro = esPatron ? 0.02m * sbc : 0m * sbc;
                aportaciones.Cesantia = esPatron ? 0.0315m * sbc : 0.01125m * sbc;
                aportaciones.Infonavit = esPatron ? 0.05m * sbc : 0m * sbc;
            }
           

            return aportaciones;
        }
    }
}
