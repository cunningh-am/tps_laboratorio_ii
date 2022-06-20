using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioNS;

namespace Formularios
{
    public partial class FormVenta : Form
    {
        List<Cliente> clientes;
        List<Producto> productos;

        public List<Producto> Productos
        {
            get { return this.productos; }
        }

        public FormVenta()
        {
            InitializeComponent();
        }
        public FormVenta(List<Cliente> clientes, List<Producto> productos):this()
        {
            this.clientes = clientes;
            this.productos = productos;
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            cb_cliente.DataSource = clientes;
            cb_producto.DataSource = productos;
        }

        private void btn_vender_Click(object sender, EventArgs e)
        {
            ((Producto)cb_producto.SelectedItem).UnoMasVendido();
            this.DialogResult = DialogResult.OK;
        }
    }
}
