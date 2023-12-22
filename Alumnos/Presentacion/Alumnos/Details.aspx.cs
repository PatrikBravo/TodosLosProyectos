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
    public partial class Details : System.Web.UI.Page
    {
        Negocio_Alumno _nAlumno = new Negocio_Alumno();
        Negocio_Estado _nEstado = new Negocio_Estado();
        Negocio_EstatusAlumno _nEstatusA = new Negocio_EstatusAlumno();

        Alumno alumno;
        Estado estado;
        EstatusAlumno estatusAlumno;

        ItemTablaISR isr = new ItemTablaISR();
        AportacionesIMSS aportacio = new AportacionesIMSS();

        int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            id = 4;//int.Parse(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                alumno = _nAlumno.Consulta(id);
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

                //------------------------------------------------

                /*isr = _nAlumno.CalcularISR(id);
                lblimiteinferior.Text = isr.Límite_inferior.ToString("$#0.#0");
                lblimitesuperior.Text = isr.Límite_superior.ToString("$#0.#0");
                lbcuota.Text = isr.CuotaFija.ToString("$#0.#0");
                lbexcedente.Text = isr.Excedente.ToString("$#0.#0");
                lbsubsidio.Text = isr.Subsidio.ToString("$#0.#0");
                lbisr.Text = isr.ISR.ToString("$#0.#0");*/
            }
        }

        protected void btnimss_Click(object sender, EventArgs e)
        {
            aportacio = _nAlumno.CalcularIMSS(id);
            lbenfermedad.Text = aportacio.EnfermedadMaternidad.ToString("$#0.#0");
            lbinvalides.Text = aportacio.InvalidezVida.ToString("$#0.#0");
            lbretiro.Text = aportacio.Retiro.ToString("$#0.#0");
            lbcesantia.Text = aportacio.Cesantia.ToString("$#0.#0");
            lbinfonavit.Text = aportacio.Infonavit.ToString("$#0.#0");

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModalIMSS').modal();", true);
        }
    }
}