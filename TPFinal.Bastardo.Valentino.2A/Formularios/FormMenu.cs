using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InventarioNS;
using System.Threading;
using System.Threading.Tasks;

namespace Formularios
{
    public partial class FormMenu : Form
    {
        private Inventario inv;
        private List<Cliente> clientes;
        AccesoSql sql = new AccesoSql();

        public delegate int DelegadoOrdenar(Producto prod1, Producto prod2);
        DelegadoOrdenar ordenarNom = new DelegadoOrdenar(Producto.OrdenarAlfabeticamente);
        DelegadoOrdenar ordenarPre = new DelegadoOrdenar(Producto.OrdenarPrecio);

        EventoColor eventoColor = new EventoColor();
        public FormMenu()
        {
            InitializeComponent();
            clientes = new List<Cliente>();

        }
        public async void ActualizarLista()
        {
            inv.Lista = await sql.ObtenerListaProductos();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            inv = new Inventario("Inca Games");
            try
            {
                ActualizarLista();
                

            }
            catch (Exception)
            {

                MessageBox.Show("Se produjo un error cargando la base de datos, utilice archivos.");
            }
        }
        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            FormNuevoProducto nuevoProd;
            nuevoProd = new FormNuevoProducto(inv,sql);
            DialogResult resultado = nuevoProd.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                MessageBox.Show("Producto agregado");
                inv = nuevoProd.GetInventario;
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("No se agregó un producto","Operacion cancelada",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }

        private void btn_VerProducto_Click(object sender, EventArgs e)
        {
            FormMostrar<Producto> listadoProductos = new FormMostrar<Producto>(inv.Lista);
            DialogResult resultado = listadoProductos.ShowDialog();

        }
        public static Producto CalcularProductoMasVendido(List<Producto> prodLista)
        {
            Producto auxProd = new Videojuego("No vendiste ningun juego", 0d, 0, TipoConsola.PS2, Genero.Otro);
            foreach (Producto prod in prodLista)
            {
                if (prod.UnidadesVendidas > auxProd.UnidadesVendidas)
                {
                    auxProd = prod;
                }
            }
            return auxProd;

        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            FormNuevoCliente nuevoCliente;
            nuevoCliente = new FormNuevoCliente(clientes);
            DialogResult resultado = nuevoCliente.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Cliente agregado con exito");
                clientes = nuevoCliente.Lista; 
            }
            else
            {
                MessageBox.Show("Cancelado");
            }

        }

        private void btn_VerClientes_Click(object sender, EventArgs e)
        {
            FormMostrar<Cliente> listadoClientes = new FormMostrar<Cliente>(clientes);
            DialogResult resultado = listadoClientes.ShowDialog();
        }

        private void btn_toTxt_Click(object sender, EventArgs e)
        {
            Archivo.Escribir(inv.ToString());
            MessageBox.Show("Archivo guardado con exito");
        }

        private void btn_toJson_Click(object sender, EventArgs e)
        {
            SerializadorJSON<List<Cliente>>.Escribir(clientes,"Clientes");
            MessageBox.Show("Archivo guardado con exito");
        }

        private void btn_toXML_Click(object sender, EventArgs e)
        {
            SerializadorXML<List<Producto>>.Escribir(inv.Lista, "Productos");
            MessageBox.Show("Archivo guardado con exito");
        }

        private void btn_fromJson_Click(object sender, EventArgs e)
        {
            try
            {
                clientes = SerializadorJSON<List<Cliente>>.Leer("Clientes");
                this.eventoColor.cambiarColor += CambiarColor;
                this.eventoColor.CambiarColor();
                
                MessageBox.Show("Archivo cargado con exito");
            }
            catch (Exception)
            {

                MessageBox.Show("No hay archivo JSON de clientes, genere uno primero");
            }
          
        }

        private void btn_fromXML_Click(object sender, EventArgs e)
        {
            try
            {
                inv.Lista = SerializadorXML<List<Producto>>.Leer("Productos");
                MessageBox.Show("Archivo cargado con exito");
            }
            catch (Exception)
            {

                MessageBox.Show("No hay archivo XML de productos, genere uno primero");
            }

        }
        private void btn_Ganancias_Click_1(object sender, EventArgs e)
        {
            FormGanancia ganancias = new FormGanancia(inv);
            DialogResult resultado = ganancias.ShowDialog();

        }

        private void btn_ConcretarVenta_Click_1(object sender, EventArgs e)
        {
            if (clientes.Count > 0 && inv.Lista.Count > 0)
            {
                FormVenta formVenta;
                formVenta = new FormVenta(clientes, inv.Lista);
                DialogResult resultado = formVenta.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    MessageBox.Show("Venta concretada con exito");
                    inv.Lista = formVenta.Productos;
                }
                else
                {
                    MessageBox.Show("Venta cancelada");
                }

            }
            else
            {
                MessageBox.Show("Debe cargar primero al menos 1 cliente y 1 producto.");
            }


        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            FormEliminar eliminarProd = new FormEliminar(inv.Lista,sql);
            DialogResult resultado = eliminarProd.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Producto eliminado con exito");
                inv.Lista = eliminarProd.Productos;
            }
            else
            {
                MessageBox.Show("Cancelado");
            }

        }

        private void btn_sortNombre_Click(object sender, EventArgs e)
        {
            inv.Lista.Sort((x, y) => ordenarNom(x,y));
        }

        private void btn_sortPrecio_Click(object sender, EventArgs e)
        {
            inv.Lista.Sort((x, y) => ordenarPre(x, y));
        }
        /// <summary>
        /// Calcula cual es el producto con mas unidades vendidas utilizando un juego auxiliar
        /// </summary>
        /// <param name="prodLista"></param>
        /// <returns></returns>
        public void CambiarColor()
        {
            this.btn_VerClientes.BackColor = this.btn_AgregarCliente.BackColor;
        }
 
    }
}
