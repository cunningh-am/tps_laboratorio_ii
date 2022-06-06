using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioNS
{

    public class PlayStation2:Consola,IMostrar
    {
        protected TipoConsola tipo;

        public override TipoConsola Tipo
        {
            get { return tipo; }
            set { this.tipo = value; }
        }
        public PlayStation2()
        {

        }
        public PlayStation2(Consola consola):this(consola.Nombre,consola.Precio,consola.UnidadesVendidas, consola.Color)
        {
            
        }
        public PlayStation2(string nombre, float precio, int unidadesVendidas, Color color) :base(nombre,precio, unidadesVendidas, color)
        {
            this.tipo = TipoConsola.PS2;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($" █ COLOR: {this.color.ToString()}");
            sb.AppendLine(" █ FABRICANTE: Sony");

            return sb.ToString();
        }
        public override string ToString()
        {
            return Mostrar();
        }
        public static bool operator ==(PlayStation2 ps1, PlayStation2 ps2)
        {
            if (ps1.color == ps2.color)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(PlayStation2 ps1, PlayStation2 ps2)
        {
            return !(ps1 == ps2);
        }
    }
}
