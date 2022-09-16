using MySql.Data.MySqlClient;
using capaEntidad;

namespace capaDatos
{
    public class CDCliente
    {
        string CadenaConexion = "Server=localhost;User=root;Password=sa123456;Port=3306;database=curso_cs";
        
        public void PruebaConexion()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);

            try
            {
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión" + ex.Message);
                return;
            }

            mySqlConnection.Close();
            MessageBox.Show("Conectado!");
        }

        public void Crear(CECliente cE ) 
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "INSERT INTO `clientes` (`nombre`, `apellido`, `foto`) VALUES ('"+ cE.Nombre +"', '"+ cE.Apellido +"', '" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(cE.Foto)+ "');";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro creado!");
        }
    }
}