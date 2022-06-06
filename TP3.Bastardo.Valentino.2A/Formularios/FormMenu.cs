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
    public partial class FormMenu : Form
    {
        private Inventario inv;
        private List<Cliente> clientes;
        public FormMenu()
        {
            InitializeComponent();
            clientes = new List<Cliente>();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            inv = new Inventario("Inca Games");
        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            FormNuevoProducto nuevoProd;
            nuevoProd = new FormNuevoProducto(inv);
            DialogResult resultado = nuevoProd.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                MessageBox.Show("Producto agregado");
                inv = nuevoProd.GetInventario;
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
    }
}
