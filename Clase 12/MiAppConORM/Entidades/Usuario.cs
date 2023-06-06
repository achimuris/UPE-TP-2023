using System;
using System.Collections.Generic;

namespace Entidades
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreDeUsuario { get; set; } = null!;
        public string Clave { get; set; } = null!;
        public int IdPerfil { get; set; }

        public virtual Perfil IdPerfilNavigation { get; set; } = null!;
    }
}
