using System;
using System.Collections.Generic;

namespace Entidades
{
    public partial class Carrera
    {
        public Carrera()
        {
            Materia = new HashSet<Materium>();
        }

        public int IdCarrera { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Materium> Materia { get; set; }
    }
}
