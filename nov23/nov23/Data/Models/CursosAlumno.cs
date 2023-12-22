using System;
using System.Collections.Generic;

namespace nov23.Data.Models
{
    public partial class CursosAlumno
    {
        public int Id { get; set; }
        public short? IdCurso { get; set; }
        public int? IdAlumno { get; set; }
        public DateTime? FechaIncripcion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public byte? Calificacion { get; set; }

        public virtual Alumno? IdAlumnoNavigation { get; set; }
        public virtual Curso? IdCursoNavigation { get; set; }
    }
}
