using MVC_Razor_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Razor_EF.Controllers
{
    public class AlumnoController : Controller
    {
        private InstitutoTichEntities _DBModel = new InstitutoTichEntities();
        private List<Alumnos> _listaAlumnos;
        private Alumnos _alumnos;

        // GET: Alumno
        public ActionResult Index()
        {
            _listaAlumnos = _DBModel.Alumnos.ToList();
            return View(_listaAlumnos);
        }

        // GET: Alumno/Details/5
        public ActionResult Details(int id)
        {
            _DBModel.Configuration.LazyLoadingEnabled = false;
            _alumnos = _DBModel.Alumnos.Find(id);

            _alumnos = _DBModel.Alumnos.Include("Estados").Where(x => x.idEstadoOrigen == _alumnos.idEstadoOrigen).FirstOrDefault();
            _alumnos = _DBModel.Alumnos.Include("EstatusAlumno").Where(x => x.idEstatus == _alumnos.idEstatus).FirstOrDefault();
            
            return View(_alumnos);
        }

        // GET: Alumno/Create
        public ActionResult Create()
        {
            ViewBag.estados = _DBModel.Estados;
            ViewBag.estatus = _DBModel.EstatusAlumno;
            return View();
        }

        // POST: Alumno/Create
        [HttpPost]
        public ActionResult Create(Alumnos alumno)
        {
            try
            {
                _DBModel.Alumnos.Add(alumno);
                _DBModel.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumno/Edit/5
        public ActionResult Edit(int id)
        {
            _DBModel.Configuration.LazyLoadingEnabled = false;
            _alumnos = _DBModel.Alumnos.Find(id);

            _alumnos = _DBModel.Alumnos.Include("Estados").Where(x => x.idEstadoOrigen == _alumnos.idEstadoOrigen && x.id == _alumnos.id).FirstOrDefault();
            _alumnos = _DBModel.Alumnos.Include("EstatusAlumno").Where(x => x.idEstatus == _alumnos.idEstatus && x.id == _alumnos.id).FirstOrDefault();

            ViewBag.estados = _DBModel.Estados;
            ViewBag.estatus = _DBModel.EstatusAlumno;

            return View(_alumnos);
        }

        // POST: Alumno/Edit/5
        [HttpPost]
        public ActionResult Edit(Alumnos alumno)
        {
            try
            {
                _DBModel.Entry(alumno).State = System.Data.Entity.EntityState.Modified;
                _DBModel.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumno/Delete/5
        public ActionResult Delete(int id)
        {
            _DBModel.Configuration.LazyLoadingEnabled = false;
            _alumnos = _DBModel.Alumnos.Find(id);

            _alumnos = _DBModel.Alumnos.Include("Estados").Where(x => x.idEstadoOrigen == _alumnos.idEstadoOrigen && x.id == _alumnos.id).FirstOrDefault();
            _alumnos = _DBModel.Alumnos.Include("EstatusAlumno").Where(x => x.idEstatus == _alumnos.idEstatus && x.id == _alumnos.id).FirstOrDefault();

            return View(_alumnos);
        }

        // POST: Alumno/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _alumnos = _DBModel.Alumnos.Find(id);
                _DBModel.Alumnos.Remove(_alumnos);
                _DBModel.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
