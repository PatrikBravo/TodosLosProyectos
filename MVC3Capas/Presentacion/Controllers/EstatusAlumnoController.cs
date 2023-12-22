using Entidades;
using Negocio;
using Negocio.WCFAlumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class EstatusAlumnoController : Controller
    {
        private Negocio_EstatusAlumno _nEstatus = new Negocio_EstatusAlumno();
        private List<EstatusAlumno> _listaEstatus;

        // GET: EstatusAlumno
        public ActionResult Index()
        {
            _listaEstatus = _nEstatus.Consultar();
            return View(_listaEstatus);
        }

        // GET: EstatusAlumno/Details/5
        public ActionResult Details(int id)
        {
            return View(_nEstatus.Consulta(id));
        }

        // GET: EstatusAlumno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstatusAlumno/Create
        [HttpPost]
        public ActionResult Create(EstatusAlumno estatus)
        {
            try
            {
                _nEstatus.Agregar(estatus);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EstatusAlumno/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_nEstatus.Consulta(id));
        }

        // POST: EstatusAlumno/Edit/5
        [HttpPost]
        public ActionResult Edit(EstatusAlumno estatus)
        {
            try
            {
                _nEstatus.Actualizar(estatus);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EstatusAlumno/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_nEstatus.Consulta(id));
        }

        // POST: EstatusAlumno/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _nEstatus.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult _AjaxDelete(int id)
        {
            return PartialView(_nEstatus.Consulta(id));
        }
    }
}
