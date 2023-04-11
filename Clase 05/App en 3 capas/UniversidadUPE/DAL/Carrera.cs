using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Carrera
    {
        public bool AgregarMateria(string nombre, int idCarrera)
        {
            Conexion objConexion = new Conexion();
            string nombreStoreProcedure = "sp_insertar_materia";
            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = objConexion.crearParametro("@descripcion", nombre);
            parametros[1] = objConexion.crearParametro("@idCarrera", idCarrera);

            int cantidadDeFilasAfectadas = objConexion.EscribirPorStoreProcedure(nombreStoreProcedure, parametros);
            if (cantidadDeFilasAfectadas>0)
            {
                return true;
            }

            return false;
        }

        public DataTable DevolverCarreras()
        {
            Conexion objConexion = new Conexion();

            //DataTable dt = objConexion.LeerPorComando("select IdCarrera as ID, Nombre as Descripción from Carreraisjflkdsjakñdsf");

            DataTable dt = objConexion.LeerPorStoreProcedure("sp_listar_carreras");

            return dt;

        }

        public DataTable DevolverMaterias(int idMateria)
        {
            Conexion objConexion = new Conexion();
            string nombreStoreProcedure = "sp_materiasxcarrera";
            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = objConexion.crearParametro("@pIdCarrera", idMateria);


            DataTable dt = objConexion.LeerPorStoreProcedure(nombreStoreProcedure, parametros);

            return dt;

        }
    }
}
