using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class Negocio_Estado
    {
        Datos_Estados Datos_Estados = new Datos_Estados();
        public void Actualizar(Estado estado)
        {
            Datos_Estados.Actualizar(estado);
        }

        public void Agregar(Estado estado)
        {
            Datos_Estados.Agregar(estado);
        }

        public Estado Consulta(int id)
        {
            Estado estado = new Estado();
            estado= Datos_Estados.Consulta(id);
            return estado;
        }

        public List<Estado> Consultar()
        {
            List<Estado> listaEstados = new List<Estado>();
            listaEstados = Datos_Estados.Consultar();
            return listaEstados;
        }

        public void Eliminar(int id)
        {
            Datos_Estados.Eliminar(id);
        }
    }
}
