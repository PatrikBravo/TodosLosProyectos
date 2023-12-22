using CRUDEstatusAlumno.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDEstatusAlumno.Vistas
{
    public partial class Detalles : System.Web.UI.Page
    {
        ADOEstatusAlumno _ado = new ADOEstatusAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            Estatus estatus =_ado.Consulta(id);
            lbid.Text = estatus.id.ToString();
            lbclave.Text = estatus.clave;
            lbnombre.Text = estatus.nombre;
        }
    }
}