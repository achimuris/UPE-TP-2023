using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario
    {
        public List<EntidadNegocio.Usuario> Usuarios()
        {


            List<EntidadNegocio.Usuario> listaDeRetorno = new List<EntidadNegocio.Usuario> ();
            string nombreStoreProcedure = "sp_listar_usuarios";
            Conexion objConexion = new Conexion();

            DataTable dt = objConexion.LeerPorStoreProcedure(nombreStoreProcedure);


            EntidadNegocio.Usuario usuarioAuxiliar;
            foreach (DataRow fila in dt.Rows)
            {
                usuarioAuxiliar = new EntidadNegocio.Usuario();

                usuarioAuxiliar.ID = int.Parse(fila[0].ToString());
                usuarioAuxiliar.UserName = fila[1].ToString();
                usuarioAuxiliar.Perfil = new EntidadNegocio.Perfil();
                usuarioAuxiliar.Perfil.ID = int.Parse(fila[2].ToString());
                usuarioAuxiliar.Perfil.Descripcion = fila[3].ToString();

                listaDeRetorno.Add(usuarioAuxiliar);
            }


            return listaDeRetorno;


        }

        public EntidadNegocio.Usuario  ValidarUsuario(string username, string password)
        {
            string nombreStoreProcedure = "sp_validar_usuario";
            SqlParameter[] parametros = new SqlParameter[2];
            Conexion objConexion = new Conexion();
            parametros[0] = objConexion.crearParametro("@username", username);
            parametros[1] = objConexion.crearParametro("@password", password);

            DataTable dt = objConexion.LeerPorStoreProcedure(nombreStoreProcedure, parametros);

            if (dt == null || dt.Rows.Count == 0)
                return null;
            
            
            EntidadNegocio.Usuario usuarioDeRetorno = new EntidadNegocio.Usuario();
            int primeraFila = 0;
            usuarioDeRetorno.ID = int.Parse(dt.Rows[primeraFila][0].ToString());
            usuarioDeRetorno.UserName = dt.Rows[primeraFila]["nombreDeUsuario"].ToString();
            usuarioDeRetorno.Contraseña = password;

            usuarioDeRetorno.Perfil = new EntidadNegocio.Perfil();
            usuarioDeRetorno.Perfil.ID = int.Parse(dt.Rows[primeraFila]["IdPerfil"].ToString());
            usuarioDeRetorno.Perfil.Descripcion = dt.Rows[primeraFila][3].ToString();



            return usuarioDeRetorno;
        }
    }
}
