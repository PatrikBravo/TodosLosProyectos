using CRUDEstatusAlumno.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDEstatusAlumno.Vistas
{
    public partial class Index : System.Web.UI.Page
    {
        List<Estatus> _listaEstatus = new List<Estatus>();
        ADOEstatusAlumno _ado = new ADOEstatusAlumno();
        Estatus _estatus = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            _listaEstatus = _ado.Consultar();
            if (!IsPostBack)
            {
                ListaEstatus.DataSource = _listaEstatus;
                ListaEstatus.DataTextField = "nombre";
                ListaEstatus.DataValueField = "id";
                ListaEstatus.DataBind();
            }
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Agregar.aspx");
        }

        protected void Detalles_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ListaEstatus.SelectedValue);
            _estatus = _listaEstatus.Find(x => x.id == id);
            Response.Redirect($"Detalles.aspx?id={_estatus.id}");
        }

        protected void Editar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ListaEstatus.SelectedValue);
            _estatus = _listaEstatus.Find(x => x.id == id);
            Response.Redirect($"Actualizar.aspx?id={_estatus.id}");
        }

        protected void Elimar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ListaEstatus.SelectedValue);
            _estatus = _listaEstatus.Find(x => x.id == id);
            Response.Redirect($"Eliminar.aspx?id={_estatus.id}");
        }
    }
}