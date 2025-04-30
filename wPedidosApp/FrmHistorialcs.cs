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
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            try
            {
                cmbFiltroEntrega.SelectedIndex = 0;
                CargarPedidos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CargarPedidos(string filtro = "Todos")
        {
            try
            {
                var pedidos = RegistroPedidos.Instancia.Pedidos;
                if (filtro != "Todos")
                    pedidos = pedidos.Where(p => p.MetodoEntrega.TipoEntrega() == filtro).ToList();
                dgvHistorial.DataSource = pedidos
                .Select(p => new
                {
                    Cliente = p.Cliente,
                    Producto = p.Producto,
                    Urgente = p.Urgente,
                    Peso = p.Peso,
                    Distancia = p.Distancia,
                    TipoEntrega = p.MetodoEntrega.TipoEntrega(),
                    Costo = p.ObtenerCosto()
                }).ToList();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void cmbFiltroEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = cmbFiltroEntrega.SelectedItem.ToString();
                CargarPedidos(filtro);
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
