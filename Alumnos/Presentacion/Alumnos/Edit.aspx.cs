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
    public partial class Edit : System.Web.UI.Page
    {
        Negocio_Alumno _nAlumno = new Negocio_Alumno();
        Negocio_Estado _nEstado = new Negocio_Estado();
        Negocio_EstatusAlumno _nEstatusA = new Negocio_EstatusAlumno();
        List<Estado> _listaEstados = new List<Estado>();
        List<EstatusAlumno> _listaEstatusAlumno = new List<EstatusAlumno>();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            _listaEstados = _nEstado.Consultar();
            _listaEstatusAlumno = _nEstatusA.Consultar();
            if (!IsPostBack)
            {
                id = int.Parse(Request.QueryString["id"]); 
                Alumno alumno = new Alumno();
                alumno = _nAlumno.Consulta(id);
                tbid.Text = alumno.id.ToString();
                tbnombre.Text = alumno.nombre.ToString();
                tbprimerApellido.Text = alumno.primerApellido.ToString();
                tbsegundoApellido.Text = alumno.segundoApellido.ToString();
                tbcorreo.Text = alumno.correo.ToString();
                tbtelefono.Text = alumno.telefono.ToString();
                tbfechaNacimiento.Text = alumno.fechaNacimiento.ToString("yyyy-MM-dd");
                tbcurp.Text = alumno.curp.ToString();
                tbsueldo.Text = alumno.sueldo.ToString();
                ddidestado.SelectedValue = alumno.idEstadoOrigen.ToString();
                ddidestatus.SelectedValue = alumno.idEstatus.ToString();

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

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Alumno alumno = new Alumno();
                alumno.id = int.Parse(tbid.Text);
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
                _nAlumno.Actualizar(alumno);
            }
           
        }

        protected void vacurpYfecha_ServerValidate(object source, ServerValidateEventArgs args)
        {
            var fechanacimiento = tbfechaNacimiento.Text;
            var fechacurp = args.Value.Substring(4, 6);

            var fechaNaFormCURP = fechanacimiento.Substring(2, 2) + fechanacimiento.Substring(5, 2) + fechanacimiento.Substring(8, 2);

            args.IsValid = fechacurp == fechaNaFormCURP;
        }
    }
}