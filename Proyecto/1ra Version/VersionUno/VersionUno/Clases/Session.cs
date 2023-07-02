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

namespace VersionUno.Clases
{
    internal class Session
    {
        public static void loggear(string usuario, string passwrd, Form form)
        {

            try
            {  
                conexionbd conexion = new conexionbd();
                MySqlConnection mySqlConnection = conexion.establecerConexion();
                mySqlConnection.Open();

                //C
                string sql = "SELECT ci, id_tipo, nombre FROM usuario WHERE ci LIKE @ci AND passwrd LIKE @passwrd";
                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                comando.Parameters.AddWithValue("@ci", usuario);
                comando.Parameters.AddWithValue("@passwrd", passwrd);
                MySqlDataAdapter mda = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                mda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    
                    switch (Convert.ToInt32(dt.Rows[0][1]))
                    {
                        case 1:
                            new frmPrincipalAdmin().Show();
                            form.Hide();
                            break;
                        case 2:
                            
                            break;
                        case 3:
                            new frmPrincipalUser().Show();
                            form.Hide();
                            break;
                        default:

                            break;
                    }
                    
                }
                else 
                {
                    MessageBox.Show("Usuario y/o contraseña invalidos");
                }
               
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionbd conexion = new conexionbd();
                MySqlConnection mySqlConnection = conexion.establecerConexion();
                mySqlConnection.Close();
            }

        }

    }
}
