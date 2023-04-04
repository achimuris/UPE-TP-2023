using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Carrera
    {

        public DataTable DevolverCarreras()
        {
            Conexion objConexion = new Conexion();

            //DataTable dt = objConexion.LeerPorComando("select IdCarrera as ID, Nombre as Descripción from Carreraisjflkdsjakñdsf");

            DataTable dt = objConexion.LeerPorStoreProcedure("sp_listar_carreras");

            return dt;

        }
    }
}
