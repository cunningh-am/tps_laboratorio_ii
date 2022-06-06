using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioNS
{
    public class GameCube : Consola,IMostrar
    {
        protected TipoConsola tipo;
        public override TipoConsola Tipo
        {
            get { return tipo; }
            set { this.tipo = value; }
        }

        public GameCube()
        {

        }
        public GameCube(Consola consola) : this(consola.Nombre, consola.Precio, consola.UnidadesVendidas, consola.Color)
        {

        }
        public GameCube(string nombre, double precio, int unidadesVendidas, Color color) : base(nombre, precio, unidadesVendidas, color)
        {
            this.tipo = TipoConsola.GameCube;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($" █ COLOR: {this.color.ToString()}");
            sb.AppendLine(" █ FABRICANTE: Nintendo");

            return sb.ToString();
        }
        public override string ToString()
        {
            return Mostrar();
        }
        public static bool operator ==(GameCube gc1, GameCube gc2)
        {
            if (gc1.color == gc2.color)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(GameCube gc1, GameCube gc2)
        {
            return !(gc1 == gc2);
        }
    }
}
