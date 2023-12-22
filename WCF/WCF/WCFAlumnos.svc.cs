using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Negocio;
using System.Xml;
using System.IO;
using System.Web.Script.Serialization;

namespace WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WCFAlumnos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WCFAlumnos.svc o WCFAlumnos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WCFAlumnos : IWCFAlumnos
    {
        private Negocio_Alumno _nAlumno = new Negocio_Alumno();
        JavaScriptSerializer _serializer = new JavaScriptSerializer();

        public AportacionesIMSS CalcularIMSS(int id) 
        {
            return _serializer.Deserialize<AportacionesIMSS>(_serializer.Serialize(_nAlumno.CalcularIMSS(id)));
        }

        public ItemTablaISR CalcularISR(int id)
        {
            return _serializer.Deserialize<ItemTablaISR>(_serializer.Serialize(_nAlumno.CalcularISR(id)));
        }
    }
}
