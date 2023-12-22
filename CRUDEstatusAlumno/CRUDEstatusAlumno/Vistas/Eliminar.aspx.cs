using CRUDEstatusAlumno.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDEstatusAlumno.Vistas
{
    public partial class Eliminar : System.Web.UI.Page
    {
        ADOEstatusAlumno _ado = new ADOEstatusAlumno();
        int _id;
        protected void Page_Load(object sender, EventArgs e)
        {
            _id = int.Parse(Request.QueryString["id"]);
            Estatus estatus = _ado.Consulta(_id);
            lbid.Text = estatus.id.ToString();
            lbclave.Text = estatus.clave;
            lbnombre.Text = estatus.nombre;
            
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            _ado.Eliminar(_id);
            Response.Redirect($"Index.aspx");
        }
    }
}