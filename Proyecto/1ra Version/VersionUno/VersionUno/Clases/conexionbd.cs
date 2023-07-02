using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Libreria para conectar col la Base
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VersionUno
{  
    class conexionbd
    {
        private string servidor = "localhost";
        private string database = "versionuno";
        private string user = "root";
        private string password = "root";
        private string port = "3306";
        public MySqlConnection establecerConexion()
        {
            string cadenaConexion = "server=" + servidor + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + database + ";";

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;
        }
    }
}
