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
    public partial class FormNuevoCliente : Form,IListar<Cliente>
    {
        List<Cliente> listaClientes;
        private FormNuevoCliente()
        {
            InitializeComponent();
            listaClientes = new List<Cliente>();
        }
        public FormNuevoCliente(List<Cliente> lista):this()
        {
            this.listaClientes = lista;
        }

        private void FormNuevoCliente_Load(object sender, EventArgs e)
        {

        }
        public List<Cliente> Lista
        {
            get { return this.listaClientes; }
            set { this.listaClientes = value; }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txt_nombre.Text;
            string nuevoDni = txt_dni.Text;
            DateTime nuevaFecha = DateTime.Now;

            if(!String.IsNullOrWhiteSpace(nuevoNombre)&&
               !String.IsNullOrWhiteSpace(nuevoDni))
            {
                Cliente nuevoCliente = new Cliente(nuevoNombre, nuevoDni);
                if(!YaEstaElCliente(listaClientes,nuevoCliente))
                {
                    listaClientes.Add(nuevoCliente);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ese cliente ya se encuentra en la base de datos");
                }

            }
            else
            {
                MessageBox.Show("Debe llenar los campos");
            }

        }
        private bool YaEstaElCliente(List<Cliente> lista, Cliente auxC)
        {
            foreach(Cliente cl in lista)
            {
                if(auxC == cl)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Restringe todo input que no sean numeros, para ahorrar la validacion del dni y dar mas robustez
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
