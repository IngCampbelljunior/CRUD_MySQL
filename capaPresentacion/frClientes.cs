using capaNegocio;
using capaEntidad;

namespace capaPresentacion;

public partial class frClientes : Form
{
    
    CNCliente cNCliente = new CNCliente();
    public frClientes()
    {
        InitializeComponent();
    }

    private void frClientes_Load(object sender, EventArgs e)
    {

    }

    private void btnNuevo_Click(object sender, EventArgs e)
    {
        txtId.Value = 0;
        txtNombre.Text = string.Empty;
        txtApellido.Text = string.Empty;
        picFoto.Image = null;
    }

    private void lnkFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        ofdFoto.FileName = string.Empty;
        
        if (ofdFoto.ShowDialog()==DialogResult.OK)
        {
            picFoto.Load(ofdFoto.FileName);
        }

        ofdFoto.FileName = string.Empty;
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        bool Resultado;

        CECliente cECliente = new CECliente();
        cECliente.Id = (int)txtId.Value;
        cECliente.Nombre = txtNombre.Text;
        cECliente.Apellido = txtApellido.Text;
        cECliente.Foto = picFoto.ImageLocation;

        Resultado = cNCliente.ValidarDatos(cECliente);

        if (Resultado == false)
        {
            return;
        }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        cNCliente.PruebaMySql();
    }
}