using CRUDEstatusAlumno.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDEstatusAlumno.Vistas
{
    public partial class Actualizar : System.Web.UI.Page
    {
        ADOEstatusAlumno _ado = new ADOEstatusAlumno();
        Estatus estatus;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"]);
                Estatus estatus = _ado.Consulta(id);
                tbid.Text = estatus.id.ToString();
                tbclave.Text = estatus.clave;
                tbnombre.Text = estatus.nombre;
            }
        }

        protected void btnmodificar_Click(object sender, EventArgs e)
        {
            estatus = new Estatus();
            estatus.id = int.Parse(tbid.Text);
            estatus.clave = tbclave.Text;
            estatus.nombre = tbnombre.Text;
            _ado.Actualizar(estatus);
            Response.Redirect($"Index.aspx");
        }
    }
}