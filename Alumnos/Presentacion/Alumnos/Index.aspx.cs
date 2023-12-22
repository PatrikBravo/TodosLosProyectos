using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Presentacion.Alumnos
{
    public partial class Index : System.Web.UI.Page
    {
        Negocio_Alumno _nAlumno = new Negocio_Alumno();
        Negocio_Estado _nEstado = new Negocio_Estado();
        Negocio_EstatusAlumno _nEstatusA = new Negocio_EstatusAlumno();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTablaAlumnos();
            }
        }

        protected void gvAlumnos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName != "Page")
            {
                int renglon = Convert.ToInt16(e.CommandArgument);
                GridViewRow fila = gvAlumnos.Rows[renglon];
                TableCell celda = fila.Cells[0];
                int id = Convert.ToInt16(celda.Text);

                switch (e.CommandName)
                {
                    case "btndetalle":
                        Response.Redirect($"Details.aspx?id={id}");
                        break;
                    case "btneditar":
                        Response.Redirect($"Edit.aspx?id={id}");
                        break;
                    case "btneliminar":
                        Response.Redirect($"Delete.aspx?id={id}");
                        break;
                }
            }
        }

        protected void gvAlumnos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAlumnos.PageIndex = e.NewPageIndex;
            CargarTablaAlumnos();
        }

        private void CargarTablaAlumnos()
        {
            List<Alumno> listaAlumnos = new List<Alumno>();
            List<Estado> listaEstado = new List<Estado>();
            List<EstatusAlumno> listaEstatus = new List<EstatusAlumno>();

            listaAlumnos = _nAlumno.Consultar();
            listaEstado = _nEstado.Consultar();
            listaEstatus = _nEstatusA.Consultar();

            var consultaAlumnos = from alumnos in listaAlumnos join estados in listaEstado on alumnos.idEstatus equals estados.id
                        join estatus in listaEstatus on alumnos.idEstatus equals estatus.id select new
                        { id = alumnos.id, nombre = alumnos.nombre, primerApellido = alumnos.primerApellido,
                          segundoApellido = alumnos.segundoApellido, correo = alumnos.correo, telefono = alumnos.telefono,
                            fechaNacimiento=alumnos.fechaNacimiento, curp = alumnos.curp, sueldo = alumnos.sueldo,
                            idEstadoOrigen = estados.nombre, idEstatus = estatus.nombre
                        };


            gvAlumnos.DataSource = consultaAlumnos.ToList();
            gvAlumnos.DataBind();
        }

        protected void btnVistaAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Create.aspx");
        }
    }
}