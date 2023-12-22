using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class Negocio_EstatusAlumno
    {
        Datos_Estatus Datos_Estatus = new Datos_Estatus();
        public void Actualizar(EstatusAlumno estatus)
        {
            Datos_Estatus.Actualizar(estatus);
        }

        public void Agregar(EstatusAlumno estatus)
        {
            Datos_Estatus.Agregar(estatus);
        }

        public EstatusAlumno Consulta(int id)
        {
            EstatusAlumno estatusAlumno = new EstatusAlumno();
           estatusAlumno = Datos_Estatus.Consulta(id);
            return estatusAlumno;
        }

        public List<EstatusAlumno> Consultar()
        {
            List<EstatusAlumno> listaEstatus = new List<EstatusAlumno>();
           listaEstatus = Datos_Estatus.Consultar();
            return listaEstatus;
        }

        public void Eliminar(int id)
        {
            Datos_Estatus.Eliminar(id);
        }
    }
}
