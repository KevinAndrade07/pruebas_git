using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    class ConexionDB
    {
        public static class ConexionBD
        {
            public static string CadenaConexion => @"Server=TS-WSI-013\SQLEXPRESS;Database=universidad;Integrated Security=True;";
        }

    }
}
