using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioNS
{
    /// <summary>
    /// Clase sin implementacion aun, sera utilizada para gestionar pedidos, vinculando un producto, un cliente, y asignando una fecha unica.
    /// </summary>
    public class Pedido
    {

        DateTime fecha;
        Cliente cliente;
        Producto producto;

        public Pedido(Cliente cliente, Producto producto)
        {
            this.cliente = cliente;
            this.producto = producto;
            this.fecha = DateTime.Now;

        }

    }
}
