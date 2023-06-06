using System;
using System.Collections.Generic;

namespace Entidades
{
    public partial class Materium
    {
        public int IdMateria { get; set; }
        public string? Descripcion { get; set; }
        public int? IdCarrera { get; set; }
        public string? ProfesorTitular { get; set; }
        public int Anio { get; set; }
        public virtual Carrera? IdCarreraNavigation { get; set; }
    }
}
