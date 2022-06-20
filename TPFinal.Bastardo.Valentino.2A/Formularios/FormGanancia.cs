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
    public partial class FormGanancia : Form
    {
        Inventario inv;
        private FormGanancia()
        {
            InitializeComponent();
        }
        public FormGanancia(Inventario inv):this()
        {
            this.inv = inv;
        }

        private void FormGanancia_Load(object sender, EventArgs e)
        {
            lbl_ganancia.Text = inv.ToString();
            richTextBox1.Text = inv.MostrarInventario();
        }
    }
}
