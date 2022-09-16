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

            MessageBox.Show("Conectado!");
        }
    }
}