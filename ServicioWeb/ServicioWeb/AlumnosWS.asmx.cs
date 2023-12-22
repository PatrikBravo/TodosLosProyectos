using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Entidades;

namespace ServicioWeb
{
    /// <summary>
    /// Descripción breve de AlumnosWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class AlumnosWS : System.Web.Services.WebService
    {

        [WebMethod]
        public ItemTablaISR CalcularISR(int id)
        {
            Negocio.Negocio_Alumno datos_alumno = new Negocio.Negocio_Alumno();
            ItemTablaISR isr = datos_alumno.CalcularISR(id);
            return isr;
        }

        [WebMethod]
        public AportacionesIMSS CalcularIMSS(int id)
        {
            Negocio.Negocio_Alumno datos_alumno = new Negocio.Negocio_Alumno();
            AportacionesIMSS imss = datos_alumno.CalcularIMSS(id);
            return imss;
        }
    }
}
