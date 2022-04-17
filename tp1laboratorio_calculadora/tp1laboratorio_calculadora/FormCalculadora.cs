using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace tp1laboratorio_calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();

            
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numStr1 = txtNumero1.Text;           // recogen la informacion del form
            string numStr2 = txtNumero2.Text;
            string operadorStr = cmbOperador.Text; ; 

            bool validandoOpCargado = Char.TryParse(operadorStr, out char operador); // estas 3 lineas intentan parsear operadores y operando al valor que corresponde
            bool validandoNoTexto1 = Double.TryParse(numStr1, out double num1);      
            bool validandoNoTexto2 = Double.TryParse(numStr2, out double num2);

            if (validandoOpCargado is true && validandoNoTexto1 is true && validandoNoTexto2 is true) // en caso de que no sean los indicados, no permite operar 
            {
                Operando operando1 = new Operando(num1);
                Operando operando2 = new Operando(num2);

                double resultado = CalculadoraCs.Operar(operando1, operando2, operador);
                lblResultado.Text = Convert.ToString(resultado);
                lstOperaciones.Items.Add($"{numStr1}{operador}{numStr2} = {Convert.ToString(resultado)}");
            }
            else
            {
                string mensaje = "Operandos u operador invalido.";
                string titulo = "Error";
                MessageBoxIcon icono = MessageBoxIcon.Error;
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, titulo,boton,icono);
            }


        }
        /// <summary>
        /// Cambia los valores de las text boxes, el combo box y el label a sus valores por default
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            cmbOperador.SelectedIndex = 0;
            lblResultado.Text = "0";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuestaUsuario = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuestaUsuario == DialogResult.No)
            {
                e.Cancel = true;
            }


        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

            Double.TryParse(lblResultado.Text, out double resultado);

            if(resultado>0)
            {
                lblResultado.Text = Operando.DecimalBinario(resultado);

            }
            else
            {
                MessageBox.Show("Valor invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultado = lblResultado.Text;
            lblResultado.Text = Operando.BinarioDecimal(resultado);
        }
    }
}
