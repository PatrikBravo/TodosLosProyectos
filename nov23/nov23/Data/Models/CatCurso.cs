using System;
using System.Collections.Generic;

namespace nov23.Data.Models
{
    public partial class CatCurso
    {
        public CatCurso()
        {
            Cursos = new HashSet<Curso>();
            InverseIdPrerequisitoNavigation = new HashSet<CatCurso>();
        }

        public short Id { get; set; }
        public string? Clave { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public byte? Horas { get; set; }
        public short? IdPrerequisito { get; set; }
        public bool? Activo { get; set; }

        public virtual CatCurso? IdPrerequisitoNavigation { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
        public virtual ICollection<CatCurso> InverseIdPrerequisitoNavigation { get; set; }
    }
}
