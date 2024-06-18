using MySql.Data.MySqlClient;

namespace ClassLibrary1
{
    public class ConexionDB
    {
        private MySqlConnection connect;
        private string server = "localhost";
        private string database = "estudiante_db";
        private string user = "root";
        private string passwd = "";

        private string cadenaConexion;

        public ConexionDB() {
            cadenaConexion = "Database=" + database +
                 "; DataSource=" + server +
                 "; User Id=" + user +
                 "; Password=" + passwd;
        }
  
        public void CloseConection()
        {
            if (connect != null)
            {
                connect.Close();
            }
        }

        public static int sumar(int a, int b) {
            return a + b; 
        }
        public bool getConexion()
        {
            try
            {

                if (cadenaConexion != null)
                {
                    connect = new MySqlConnection(cadenaConexion);
                    connect.Open();
                    //MessageBox.Show("Ok");
                    return true; 
                }
                return  false; 
            }
            catch (MySqlException ex)
            {
                return false; 
                //MessageBox.Show("Errro en la conexion");
            }

        }

        public List<List<string>> getEstudiantes()
        {
            List<List<string>> resultados = new List<List<string>>();

            try
            {
                MySqlDataReader mySqlDataReader;
                getConexion();
                if (connect != null)
                {
                    string consulta = "Select * from estudiante";
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                    mySqlCommand.Connection = connect;
                    mySqlDataReader = mySqlCommand.ExecuteReader();

                    List<string> sublist1;
                    while (mySqlDataReader.Read())
                    {
                        sublist1 = new List<string>();
                        sublist1.Add(mySqlDataReader["cedula_identidad"].ToString());
                        sublist1.Add(mySqlDataReader["nombre"].ToString());
                        sublist1.Add(mySqlDataReader["apellido_paterno"].ToString());
                        sublist1.Add(mySqlDataReader["apellido_materno"].ToString());
                        sublist1.Add(mySqlDataReader["fecha_nacimiento"].ToString());
                        sublist1.Add(mySqlDataReader["correo_electronico"].ToString());
                        resultados.Add(sublist1);
                    }
                    Console.WriteLine(resultados);
                }
                else
                {
                    //MessageBox.Show("Error en conexion");
                    return null; 
                }
            }
            catch (MySqlException exe)
            {
                return null; 
                //MessageBox.Show("Error en la consulta" + exe.Message);
            }
            finally
            {
                CloseConection();
            }

            return resultados;
        }

    }
}
