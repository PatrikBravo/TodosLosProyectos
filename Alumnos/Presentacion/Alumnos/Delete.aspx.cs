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
    public partial class Delete : System.Web.UI.Page
    {
        Negocio_Alumno _nAlumno = new Negocio_Alumno();
        Negocio_Estado _nEstado = new Negocio_Estado();
        Negocio_EstatusAlumno _nEstatusA = new Negocio_EstatusAlumno();

        Alumno alumno;
        Estado estado;
        EstatusAlumno estatusAlumno;

        int _id;
        protected void Page_Load(object sender, EventArgs e)
        {
            _id = int.Parse(Request.QueryString["id"]);
            alumno = _nAlumno.Consulta(_id);
            estado = _nEstado.Consulta(alumno.idEstadoOrigen);
            estatusAlumno = _nEstatusA.Consulta(alumno.idEstatus);

            lbid.Text = alumno.id.ToString();
            lbnombre.Text = alumno.nombre.ToString();
            lbprimerApellido.Text = alumno.primerApellido.ToString();
            lbsegundoApellido.Text = alumno.segundoApellido.ToString();
            lbcorreo.Text = alumno.correo.ToString();
            lbtelefono.Text = alumno.telefono.ToString();
            lbfechaNacimiento.Text = alumno.fechaNacimiento.ToString("yyyy-MM-dd");
            lbcurp.Text = alumno.curp.ToString();
            lbsueldo.Text = alumno.sueldo.ToString();
            lbidestado.Text = estado.nombre.ToString();
            lbidestatus.Text = estatusAlumno.nombre.ToString();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            _nAlumno.Eliminar(_id);
        }
    }
}