using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioNS
{
    /// <summary>
    /// esta excepcion es utilizada cuando un producto ya se encuentra dentro de la lista de un inventario
    /// </summary>
    public class InventarioException : Exception
    {
        string nombreClase;
        string nombreMetodo;

        public string NombreClase
        {
            get
            {
                return nombreClase;
            }

        }
        public string NombreMetodo
        {
            get
            {
                return nombreMetodo;
            }

        }
        public InventarioException(string mensaje, string clase, string metodo) : base(mensaje)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        public InventarioException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
