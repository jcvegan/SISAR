using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SISAR.Acceso
{
    class Conexion
    {
        static string conexion = "data source=localhost;Initial Catalog=SISAR_BD;Integrated Security=SSPI;";

        public static string CadConexion
        {
            get { return conexion; }
        }
        
    }
}
