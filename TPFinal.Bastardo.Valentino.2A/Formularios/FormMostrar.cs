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
    public partial class FormMostrar<T> :Form
    {
        private List<T> lista;

        private FormMostrar()
        {
            InitializeComponent();
        }
        public FormMostrar(List<T> lista) : this()
        {
            this.lista = lista;
        }

        private void FormMostrar_Load(object sender, EventArgs e)
        {
            lb_1.DataSource = lista;
        }


        private void lb_1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
