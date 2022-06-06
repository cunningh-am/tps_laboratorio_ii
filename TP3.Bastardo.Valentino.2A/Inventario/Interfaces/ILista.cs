using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioNS
{
    public interface IListar<T> where T: class
    {
        /// <summary>
        /// interfaz para el manejo de listas
        /// </summary>
        List<T> Lista
        {
            get;
            set;
        }

    }
}
