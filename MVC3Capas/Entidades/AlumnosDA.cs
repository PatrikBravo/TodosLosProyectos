using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [MetadataType(typeof(AlumnosDataAnnotations))]
    public partial class Alumnos
    {
    }
    public class AlumnosDataAnnotations
    {
        //============================================================
        [DisplayName("ID")]
        public int id { get; set; }
        //============================================================
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [RegularExpression("[a-zA-ZÁÉÍÓÚáéíóúñÑ]+(\\s*[a-zA-ZÁÉÍÓÚáéíóúñÑ]*)*[a-zA-ZÁÉÍÓÚáéíóúñÑ]+$", ErrorMessage = "El {0} no tiene el formato correcto")]
        public string nombre { get; set; }
        //============================================================
        [DisplayName("Primer Apellido")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [RegularExpression("[a-zA-ZÁÉÍÓÚáéíóúñÑ]+(\\s*[a-zA-ZÁÉÍÓÚáéíóúñÑ]*)*[a-zA-ZÁÉÍÓÚáéíóúñÑ]+$", ErrorMessage = "El {0} no tiene el formato correcto")]
        public string primerApellido { get; set; }
        //============================================================
        [DisplayName("Segundo Apellido")]
        [RegularExpression("[a-zA-ZÁÉÍÓÚáéíóúñÑ]+(\\s*[a-zA-ZÁÉÍÓÚáéíóúñÑ]*)*[a-zA-ZÁÉÍÓÚáéíóúñÑ]+$", ErrorMessage = "El {0} no tiene el formato correcto")]
        public string segundoApellido { get; set; }
        //============================================================
        [DisplayName("Correo")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string correo { get; set; }
        //============================================================
        [DisplayName("Telefono")]
        public string telefono { get; set; }
        //============================================================
        [DisplayName("Fecha Nacimiento")]
        [Required(ErrorMessage = "La {0} es obligatoria")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [CustomDateRange("1990-01-01", "2000-12-31", ErrorMessage = "La {0} no esta en el rango de 1990-01-01 y 2000-12-30.")]
        public Nullable<DateTime> fechaNacimiento { get; set; }
        //============================================================
        [DisplayName("Curp")]
        [Required(ErrorMessage = "La {0} es obligatoria")]
        [RegularExpression("^([A-Z][AEIOUX][A-Z]{2}\\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\\d])(\\d)$", ErrorMessage = "El {0} no tiene el formato")]
        public string curp { get; set; }
        //============================================================
        [DisplayName("Sueldo")]
        [Range(10000, 40000, ErrorMessage = "El {0} debe estar entre {1} y {2} pesos")]
        [DataType(DataType.Currency, ErrorMessage = "No es una moneda valida")]
        public Nullable<decimal> sueldo { get; set; }
        //============================================================
        [DisplayName("Estado")]
        public Nullable<int> idEstadoOrigen { get; set; }
        //============================================================
        [DisplayName("Estatus")]
        public Nullable<short> idEstatus { get; set; }
        //============================================================
    }
}
