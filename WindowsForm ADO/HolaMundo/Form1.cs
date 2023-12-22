using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        List<Estatus> _listaEstatus = new List<Estatus>();
        ADOEstatus _ado = new ADOEstatus();
        Estatus _estatus = null;
        int opc=0,id;

        public void Cargar()
        {
            _listaEstatus.Clear();
            grid.ClearSelection();
            _listaEstatus = _ado.Consultar();
            grid.DataSource = _listaEstatus;
            cbxNombre.DataSource = _listaEstatus;
            panel.Visible = false;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        public void Ocultar()
        {
            panel.Visible = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            label3.Visible = false;
            txbid.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();

            Cargar();
            cbxNombre.DisplayMember = "nombre";
            cbxNombre.ValueMember = "id";
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ocultar();
            Guardar.Text = "Guardar";
            txbClave.Enabled = true;
            txbNombre.Enabled = true;
            label3.Visible = true;
            txbid.Visible = true;
            txbid.Text = "";
            txbClave.Text = "";
            txbNombre.Text = "";
            opc = 1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Ocultar();
            Guardar.Text = "Modificar";
            id = (int)cbxNombre.SelectedValue;
            _estatus = _listaEstatus.First(x => x.id == id);
            txbClave.Text = _estatus.clave;
            txbNombre.Text = _estatus.nombre;
            opc = 2;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Ocultar();
            Guardar.Text = "Eliminar";
            txbClave.Enabled = false;
            txbNombre.Enabled = false;
            id = (int)cbxNombre.SelectedValue;
            _estatus = _listaEstatus.First(x => x.id == id);
            txbClave.Text = _estatus.clave;
            txbNombre.Text = _estatus.nombre;
            opc = 3;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (txbClave.Text != "" && txbClave.Text != "")
            {
                switch(opc)
                {
                    case 1:
                        Estatus status = new Estatus();
                        status.id = int.Parse(txbid.Text);
                        status.clave = txbClave.Text;
                        status.nombre = txbNombre.Text;
                        _ado.Agregar(status);
                        break;
                    case 2:
                        _estatus.clave = txbClave.Text;
                        _estatus.nombre = txbNombre.Text;
                        _ado.Actualizar(_estatus);
                        break;
                    case 3:
                        _ado.Eliminar(id);
                        break;
                }
                Cargar();
            }
            else
            {
                MessageBox.Show("Ingrese clave y nombre", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
