using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Usuario
    {
        public EntidadNegocio.Usuario ValidarUsuario(string nombreUsuario, string unaPassword)
        {

            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                throw new EntidadNegocio.Excepciones.ExcepcionDeNegocio("Falta completar el nombre de usuario");
            }

            if (string.IsNullOrWhiteSpace(unaPassword))
            {
                throw new EntidadNegocio.Excepciones.ExcepcionDeNegocio("Falta completar la contraseña de usuario");
            }

            //Es porque tiene nombre y password

            Datos.Usuario dalUsuario = new Datos.Usuario();

            return dalUsuario.ValidarUsuario(nombreUsuario, unaPassword);
        }

        public bool CrearUsuario(EntidadNegocio.Usuario usuario)
        {
            return true;
        }


        public List<EntidadNegocio.Usuario> Usuarios()
        {

            Datos.Usuario dalUsuario = new Datos.Usuario();


            return dalUsuario.Usuarios();
        }

    }
}
