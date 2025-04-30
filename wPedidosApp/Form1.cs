using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wPedidosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string cliente = "";
                string producto = "";
                //Validaciones
                if (string.IsNullOrEmpty(txtCliente.Text.Trim().ToUpper()))
                    throw new ArgumentException("El nombre del cliente no puede estar vacío");
                else
                    cliente = txtCliente.Text.Trim().ToUpper();

                if (cmbProducto.SelectedIndex == -1)
                    throw new ArgumentException("Debe seleccionar un tipo de producto");
                else
                    producto = cmbProducto.SelectedItem.ToString();

                bool urgente = chkUrgente.Checked;

                double peso = Convert.ToDouble(nudPeso.Value);
                if (peso <= 0)
                    throw new ArgumentException("El peso debe ser mayor que cero");

                int distancia = Convert.ToInt32(nudDistancia.Value);
                if (distancia <= 0)
                    throw new ArgumentException("La distancia debe ser mayor que cero");

                Pedido pedido = new Pedido(cliente, producto, urgente, peso, distancia);
                RegistroPedidos.Instancia.AgregarPedido(pedido);
                lblResultado.Text = $"Entrega: {pedido.MetodoEntrega.TipoEntrega()} " +
                                    $"Costo: ${pedido.ObtenerCosto():0.00}";
                //limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Hay campos vacíos o datos Invalidos. \n" + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }





    }
}
