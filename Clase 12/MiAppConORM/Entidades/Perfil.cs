using System;
using System.Collections.Generic;

namespace Entidades
{
    public partial class Perfil
    {
        public Perfil()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdPerfil { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
