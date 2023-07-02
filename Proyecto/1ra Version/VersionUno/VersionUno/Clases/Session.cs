using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VersionUno.Clases
{
    internal class Session
    {
        public static void loggear(string usuario, string passwrd, Form form)
        {
            try
            {
                // Crear una instancia de la clase `conexionbd` para establecer la conexión a la base de datos
                conexionbd conexion = new conexionbd();
                MySqlConnection mySqlConnection = conexion.establecerConexion();
                mySqlConnection.Open();

                // Definir la consulta SQL para seleccionar el nombre de usuario, tipo de usuario y nombre desde la tabla `usuario`
                string sql = "SELECT ci, id_tipo, nombre FROM usuario WHERE ci LIKE @ci AND passwrd LIKE @passwrd";
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);

                // Agregar los parámetros de la consulta SQL
                comando.Parameters.AddWithValue("@ci", usuario);
                comando.Parameters.AddWithValue("@passwrd", passwrd);

                // Ejecutar la consulta y llenar un objeto DataTable con los resultados
                MySqlDataAdapter mda = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                mda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    // Verificar el tipo de usuario y realizar acciones específicas
                    switch (Convert.ToInt32(dt.Rows[0][1]))
                    {
                        case 1:
                            // Mostrar el formulario principal para el tipo de usuario "admin"
                            new frmPrincipalAdmin().Show();
                            form.Hide();
                            break;
                        case 2:
                            // Realizar acciones para el tipo de usuario 2 (se puede agregar el código correspondiente aquí)
                            break;
                        case 3:
                            // Mostrar el formulario principal para el tipo de usuario "user"
                            new frmPrincipalUser().Show();
                            form.Hide();
                            break;
                        default:
                            // Realizar acciones para otros tipos de usuario si es necesario
                            break;
                    }
                }
                else if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(passwrd) || usuario == "User" || passwrd == "Password")
                {
                    // Mostrar un mensaje de advertencia si los campos están vacíos o tienen los valores predeterminados
                    MessageBox.Show("Rellene los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    // Mostrar un mensaje de advertencia si el nombre de usuario y/o la contraseña son inválidos
                    MessageBox.Show("Usuario y/o contraseña invalidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción que ocurra durante la ejecución
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Cerrar la conexión a la base de datos
                conexionbd conexion = new conexionbd();
                MySqlConnection mySqlConnection = conexion.establecerConexion();
                mySqlConnection.Close();
            }

        }

    }
}
