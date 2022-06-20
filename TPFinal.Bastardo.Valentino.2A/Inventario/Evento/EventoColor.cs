using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioNS
{
    public class EventoColor
    {
        public delegate void ColorHandler();
        public event ColorHandler cambiarColor;

        public void CambiarColor()
        {
            if (this.cambiarColor is not null)
                this.cambiarColor.Invoke();

        }
    }
}
