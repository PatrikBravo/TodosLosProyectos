using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Negocio_Estado
    {
        private readonly InstitutoTichEntities1 _DBModel = new InstitutoTichEntities1();
        private List<Estados> _listaEstados;
        private Estados _estado;

        public void Actualizar(Estados estado)
        {
            _DBModel.Entry(estado).State = EntityState.Modified;
            _DBModel.SaveChanges();
        }

        public void Agregar(Estados estado)
        {
            _DBModel.Estados.Add(estado);
            _DBModel.SaveChanges();
        }

        public Estados Consulta(int id)
        {
            _DBModel.Configuration.LazyLoadingEnabled = false;
            _estado = _DBModel.Estados.Find(id);

            return _estado;
        }

        public List<Estados> Consultar()
        {
            _listaEstados = _DBModel.Estados.ToList();
            return _listaEstados;
        }

        public void Eliminar(int id)
        {
            _estado = _DBModel.Estados.Find(id);
            _DBModel.Estados.Remove(_estado);
            _DBModel.SaveChanges();
        }
    }
}
