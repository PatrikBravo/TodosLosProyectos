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
    public partial class Create : System.Web.UI.Page
    {
        Negocio_Alumno _nAlumno = new Negocio_Alumno();
        Negocio_Estado _nEstado = new Negocio_Estado();
        Negocio_EstatusAlumno _nEstatusA = new Negocio_EstatusAlumno();
        List<Estado> _listaEstados = new List<Estado>();
        List<EstatusAlumno> _listaEstatusAlumno = new List<EstatusAlumno>();
        protected void Page_Load(object sender, EventArgs e)
        {
            _listaEstados = _nEstado.Consultar();
            _listaEstatusAlumno = _nEstatusA.Consultar();
            if (!IsPostBack)
            {
                ddidestado.DataSource = _listaEstados;
                ddidestado.DataTextField = "nombre";
                ddidestado.DataValueField = "id";
                ddidestado.DataBind();
                ddidestatus.DataSource = _listaEstatusAlumno;
                ddidestatus.DataTextField = "nombre";
                ddidestatus.DataValueField = "id";
                ddidestatus.DataBind();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Alumno alumno = new Alumno();
                alumno.nombre = tbnombre.Text;
                alumno.primerApellido = tbprimerApellido.Text;
                alumno.segundoApellido = tbsegundoApellido.Text;
                alumno.correo = tbcorreo.Text;
                alumno.telefono = tbtelefono.Text;
                alumno.fechaNacimiento = DateTime.Parse(tbfechaNacimiento.Text);
                alumno.curp = tbcurp.Text;
                alumno.sueldo = decimal.Parse(tbsueldo.Text);
                alumno.idEstadoOrigen = int.Parse(ddidestado.SelectedValue);
                alumno.idEstatus = int.Parse(ddidestatus.SelectedValue);
                _nAlumno.Agregar(alumno);
                Response.Redirect($"index.aspx");
            }
        }
    }
}