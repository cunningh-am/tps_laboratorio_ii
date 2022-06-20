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
    public partial class FormEliminar : Form
    {
        List<Producto> productos;
        public AccesoSql sql;

        public List<Producto> Productos
        {
            get { return this.productos; }
        }
        public FormEliminar()
        {
            InitializeComponent();
        }
        public FormEliminar(List<Producto> productos, AccesoSql sql):this()
        {
            this.productos = productos;
            this.sql = sql;
        }

        private void FormEliminar_Load(object sender, EventArgs e)
        {
            lb_productos.DataSource = productos;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Producto auxProd = (Producto)lb_productos.SelectedItem;
            productos.Remove(auxProd);

            if(!sql.EliminarProducto(Convert.ToInt32(auxProd.Id)))
            {
                MessageBox.Show("No se pudo eliminar de la base de datos.");
            }
            this.DialogResult = DialogResult.OK;


        }
    }
}
