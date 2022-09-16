﻿using capaEntidad;
using capaNegocio;
using capaDatos;

namespace capaNegocio
{
    public class CNCliente
    {
        CDCliente cDCliente = new CDCliente();
        public bool ValidarDatos(CECliente cliente)
        {
            bool Resultado = true;

            if (cliente.Nombre == String.Empty)
            {
                Resultado=false;
                MessageBox.Show("El nombre es obligatorio"); 
            }

            if (cliente.Apellido == String.Empty)
            {
                Resultado = false;
                MessageBox.Show("El apellido es obligatorio");
            }

            if (cliente.Foto == null)
            {
                Resultado = false;
                MessageBox.Show("La foto es obligatoria");
            }
            
            return Resultado;
        }

        public void PruebaMySql() 
        {
            cDCliente.PruebaConexion();
        }
    }
}