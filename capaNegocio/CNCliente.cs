namespace capaNegocio
{
    public class CNCliente
    {
        public bool ValidarDatos(CECliente cliente)
        {
            if (cliente.Nombre == String.Empty)
            {
                MessageBox.Show("El nombre es obligatorio"); 
            }

            if (cliente.Apellido == String.Empty)
            {
                MessageBox.Show("El apellido es obligatorio");
            }
        }
    }
}