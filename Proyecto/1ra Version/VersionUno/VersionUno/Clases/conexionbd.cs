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
    internal class conexionbd
    {
        private string servidor = "localhost";
        private string database = "versionuno";
        private string user = "root";
        private string password = "root";
        private string port = "3306";
        public MySqlConnection establecerConexion()
        {
            // Configurar la cadena de conexión utilizando los valores de las propiedades
            string cadenaConexion = "server=" + servidor + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + database + ";";

            // Crear una instancia de MySqlConnection utilizando la cadena de conexión
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            // Devolver la instancia de MySqlConnection
            return conexion;
        }
    }
}
