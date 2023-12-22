using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Negocio;

namespace MVC_Razor_ADO.Controllers
{
    public class AlumnoController : Controller
    {
        Negocio_Alumno _nAlumno = new Negocio_Alumno();
        Negocio_Estado _nestado = new Negocio_Estado();
        Negocio_EstatusAlumno _nestatusAlumno = new Negocio_EstatusAlumno();

        // GET: Alumno
        public ActionResult Index()
        {
            List<Alumno> alumnos = _nAlumno.Consultar();
            return View(alumnos);
        }
        public ActionResult Details(int id)
        {
            Alumno alumno = _nAlumno.Consulta(id);
            Estado estados = _nestado.Consulta(alumno.idEstadoOrigen);
            EstatusAlumno estatus = _nestatusAlumno.Consulta(alumno.idEstatus);
            ViewBag.estados = estados.nombre;
            ViewBag.estatus = estatus.nombre;
            return View(alumno);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Alumno alumno = _nAlumno.Consulta(id);
            Estado estados = _nestado.Consulta(alumno.idEstadoOrigen);
            EstatusAlumno estatus = _nestatusAlumno.Consulta(alumno.idEstatus);
            ViewBag.estados = estados.nombre;
            ViewBag.estatus = estatus.nombre;
            return View(alumno);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Alumno alumno)
        {
            if (alumno.id != null)
            {
                _nAlumno.Eliminar(alumno.id);
            }
            return RedirectToAction("Index", "Alumno");
        }
        [HttpGet]
        public ActionResult Create()
        {
            List<Estado> estados = _nestado.Consultar();
            List<EstatusAlumno> estatus = _nestatusAlumno.Consultar();
            ViewBag.estados = estados;
            ViewBag.estatus = estatus;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                _nAlumno.Agregar(alumno);
            }

            return RedirectToAction("Index", "Alumno");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            List<Estado> estados = _nestado.Consultar();
            List<EstatusAlumno> estatus = _nestatusAlumno.Consultar();
            ViewBag.estados = estados;
            ViewBag.estatus = estatus;
            Alumno alumno = _nAlumno.Consulta(id);
            return View(alumno);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                _nAlumno.Actualizar(alumno);
            }
            return RedirectToAction("Index", "Alumno");
        }
    }
}