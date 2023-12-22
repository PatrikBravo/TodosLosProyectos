using Datos;
using Entidades;
using Negocio;
using Negocio.WCFAlumnos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Negocio_Alumno
    {
        private InstitutoTichEntities1 _DBModel = new InstitutoTichEntities1();
        private List<Alumnos> _listaAlumnos;
        private Alumnos _alumnos;
        public void Actualizar(Alumnos alumno)
        {
            _DBModel.Entry(alumno).State = EntityState.Modified;
            _DBModel.SaveChanges();
        }

        public void Agregar(Alumnos alumno)
        {
            _DBModel.Alumnos.Add(alumno);
            _DBModel.SaveChanges();
        }

        public Alumnos Consulta(int id)
        {
            _DBModel.Configuration.LazyLoadingEnabled = false;
            _alumnos = _DBModel.Alumnos.Find(id);

            _alumnos = _DBModel.Alumnos.Include("Estados").Where(x => x.idEstadoOrigen == _alumnos.idEstadoOrigen && x.id == _alumnos.id).FirstOrDefault();
            _alumnos = _DBModel.Alumnos.Include("EstatusAlumno").Where(x => x.idEstatus == _alumnos.idEstatus && x.id == _alumnos.id).FirstOrDefault();

            return _alumnos;
        }

        public List<Alumnos> Consultar()
        {
            _listaAlumnos = _DBModel.Alumnos.ToList();
            return _listaAlumnos;
        }

        public void Eliminar(int id)
        {
            _alumnos = _DBModel.Alumnos.Find(id);
            _DBModel.Alumnos.Remove(_alumnos);
            _DBModel.SaveChanges();
        }
    }
}
