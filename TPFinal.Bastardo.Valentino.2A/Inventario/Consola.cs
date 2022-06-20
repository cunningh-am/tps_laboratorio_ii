using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioNS
{
    [System.Xml.Serialization.XmlInclude(typeof(GameCube))]
    [System.Xml.Serialization.XmlInclude(typeof(PlayStation2))]
    public abstract class Consola:Producto
    {
        protected Color color;
        public virtual Color Color
        {
            get { return color; }
            set { this.color = value; }
        }
        public abstract TipoConsola Tipo
        {
            get;
            set;
        }

        public Consola()
        {

        }
        public Consola(Producto prod, Color color) : this(prod.Nombre, prod.Precio, prod.UnidadesVendidas, color)
        {

        }
        public Consola(string nombre, double precio, int unidadesVendidas, Color color):base(nombre,precio,unidadesVendidas)
        {
            this.color = color;
        }
        public override string ToString()
        {
            return Mostrar();
        }
        public static bool operator ==(Consola cons1, Consola cons2)
        {
            if (cons1.color == cons2.color)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Consola cons1, Consola cons2)
        {
            return !(cons1 == cons2);
        }
        public override bool Equals(object obj)
        {
            if (obj is Consola && obj is not null)
            {
                return true;
            }
            return false;
        }
    }
}
