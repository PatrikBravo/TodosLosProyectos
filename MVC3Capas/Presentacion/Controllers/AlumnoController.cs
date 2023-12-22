using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Negocio;
using Negocio.WCFAlumnos;

namespace Presentacion.Controllers
{
    public class AlumnoController : Controller
    {
        private Negocio_Alumno _nAlumno = new Negocio_Alumno();
        private Negocio_Estado _nEstado = new Negocio_Estado();
        private Negocio_EstatusAlumno _Estatus = new Negocio_EstatusAlumno();
        private List<Alumnos> _listaAlumnos;

        // GET: Alumno
        public ActionResult Index()
        {
            _listaAlumnos = _nAlumno.Consultar();
            return View(_listaAlumnos);
        }

        // GET: Alumno/Details/5
        public ActionResult Details(int id)
        {
            return View(_nAlumno.Consulta(id));
        }

        // GET: Alumno/Create
        public ActionResult Create()
        {
            ViewBag.estados = _nEstado.Consultar();
            ViewBag.estatus = _Estatus.Consultar();
            return View();
        }

        // POST: Alumno/Create
        [HttpPost]
        public ActionResult Create(Alumnos alumnos)
        {
            try
            {
                _nAlumno.Agregar(alumnos);
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.estados = _nEstado.Consultar();
                ViewBag.estatus = _Estatus.Consultar();
                return View();
            }
        }

        // GET: Alumno/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.estados = _nEstado.Consultar();
            ViewBag.estatus = _Estatus.Consultar();
            return View(_nAlumno.Consulta(id));
        }

        // POST: Alumno/Edit/5
        [HttpPost]
        public ActionResult Edit(Alumnos alumnos)
        {
            try
            {
                _nAlumno.Actualizar(alumnos);

                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.estados = _nEstado.Consultar();
                ViewBag.estatus = _Estatus.Consultar();
                return View();
            }
        }

        // GET: Alumno/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_nAlumno.Consulta(id));
        }

        // POST: Alumno/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _nAlumno.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult _TablaISR(int id)
        {
            WCFAlumnosClient wCFAlumnos = new WCFAlumnosClient(); 
            return PartialView(wCFAlumnos.CalcularISR(id));
        }

        public ActionResult _AportacionesIMSS(int id)
        {
            WCFAlumnosClient wcf = new WCFAlumnosClient();
            return PartialView(wcf.CalcularIMSS(id));
        }
    }
}
