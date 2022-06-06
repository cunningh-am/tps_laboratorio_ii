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
    public partial class FormNuevoProducto : Form
    {
        private Inventario inv;
        private FormNuevoProducto()
        {
            InitializeComponent();
        }
        public FormNuevoProducto(Inventario inventario):this()
        {
            inv = inventario;
        }
        public Inventario GetInventario
        {
            get
            {
                return inv;
            }
        }

        private void FormNuevoProducto_Load(object sender, EventArgs e)
        {
            // Carga
            cb_tipo.DataSource = Enum.GetValues(typeof(TipoConsola));
            cb_genero.DataSource = Enum.GetValues(typeof(Genero));
            cb_color.DataSource = Enum.GetValues(typeof(Color));
            // Lectura
            TipoConsola tipo;
            Genero genero;
            Color color;
            Enum.TryParse<TipoConsola>(cb_tipo.SelectedValue.ToString(), out tipo);
            Enum.TryParse<Genero>(cb_genero.SelectedValue.ToString(), out genero);
            Enum.TryParse<Color>(cb_genero.SelectedValue.ToString(), out color);
            cb_genero.Enabled = false;
            cb_color.Enabled = false;


        }

        private void rb_videojuego_CheckedChanged(object sender, EventArgs e)
        {
            cb_genero.Enabled = true;
            cb_color.Enabled = false;
        }

        private void rb_consola_CheckedChanged(object sender, EventArgs e)
        {
            cb_genero.Enabled = false;
            cb_color.Enabled = true;

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            string nombreProd;
            float precioProd;
            string precioProdStr = txt_precio.Text;
            int unidadesVendidas;
            string unidadesVendidasStr = txt_unidadesVendidas.Text;
            bool esVideojuego = rb_videojuego.Checked;
            bool esConsola = rb_consola.Checked;
            TipoConsola tipo =(TipoConsola) cb_tipo.SelectedItem;

            if ( !string.IsNullOrWhiteSpace(txt_nombreProd.Text) &&
                !string.IsNullOrWhiteSpace(precioProdStr) &&
                !string.IsNullOrWhiteSpace(unidadesVendidasStr)&&
                (esVideojuego || esConsola))
            {

                nombreProd = txt_nombreProd.Text;
                nombreProd.Trim();

                precioProd = float.Parse(precioProdStr);
                unidadesVendidas = int.Parse(unidadesVendidasStr);


                if(esVideojuego)
                {
                    Genero generoSeleccionado =(Genero) cb_genero.SelectedItem;
                    Videojuego nuevoVj = new Videojuego(nombreProd, precioProd, unidadesVendidas, tipo, generoSeleccionado);
                    try
                    {
                        inv += nuevoVj;
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (InventarioException ex)
                    {

                        MessageBox.Show($"ERROR DE TIPO {ex.GetType()}: \nEse videojuego ya esta registrado");
                    }
                }
                else
                {
                    Color colorSeleccionado = (Color)cb_color.SelectedItem;
                    if(tipo == TipoConsola.PS2)
                    {
                        PlayStation2 nuevaCons = new PlayStation2(nombreProd, precioProd, unidadesVendidas, colorSeleccionado);
                        try
                        {
                            inv += nuevaCons;
                            this.DialogResult = DialogResult.OK;
                        }
                        catch (InventarioException ex)
                        {

                            MessageBox.Show($"ERROR DE TIPO {ex.GetType()}: \nEsa consola ya esta registrada");
                        }

                    }
                    else
                    {
                        GameCube nuevaCons = new GameCube(nombreProd, precioProd, unidadesVendidas, colorSeleccionado);
                        try
                        {
                            inv += nuevaCons;
                            this.DialogResult = DialogResult.OK;
                        }
                        catch (InventarioException ex)
                        {

                            MessageBox.Show($"ERROR DE TIPO {ex.GetType()}: \nEsa consola ya esta registrada");
                        }
                    }

                    
                }

            }
            else
            {
                MessageBox.Show("Debe completar correctamente todos los campos");
            }




        }

        /// <summary>
        /// Permite unicamente numeros y un solo punto decimal en el textbox, para poder llenarlo con un float y ahorrar la validacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // permite solo un punto
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Restringe todos los caracteres que no sean numericos, asegurando que solo puedas cargarle un numero entero.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_unidadesVendidas_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
