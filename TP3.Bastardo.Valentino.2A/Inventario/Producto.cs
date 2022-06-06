using System;
using System.Text;

namespace InventarioNS
{
    [System.Xml.Serialization.XmlInclude(typeof(Videojuego))]
    [System.Xml.Serialization.XmlInclude(typeof(Consola))]
    public abstract class Producto:IMostrar
    {
        protected string nombre;
        protected double precio;
        protected int unidadesVendidas;

        public virtual string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }
        public virtual double Precio
        {
            get  { return precio;}
            set { this.precio = value; }
        }
        public virtual int UnidadesVendidas
        {
            get { return unidadesVendidas; }
            set { this.unidadesVendidas = value; }
        }
        public Producto()
        {

        }
        public Producto(string nombre)
        {
            this.nombre = nombre;
            this.precio = 0;
            this.unidadesVendidas = 0;
        }
        public Producto(string nombre, double precio, int unidadesVendidas) :this(nombre)
        {

            this.precio = precio;
            this.unidadesVendidas = unidadesVendidas;
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($" █ NOMBRE: {this.nombre}");
            sb.AppendLine($" █ PRECIO: ${this.precio}");
            sb.AppendLine($" █ UNIDADES VENDIDAS: {this.unidadesVendidas}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return Mostrar();
        }
        public static bool operator ==(Producto prod1, Producto prod2)
        {
            if (prod1.GetType() == prod2.GetType() && prod1.nombre.ToLower() == prod2.nombre.ToLower())
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Cuando este implementada la venta al cliente, esta funcion se encargara de 
        /// registrar que las unidades vendidas de x producto 
        /// aumentan con cada transaccion
        /// </summary>
        internal void UnoMasVendido()
        {
            this.unidadesVendidas++;
        }
        public static bool operator !=(Producto prod1, Producto prod2)
        {
            return !(prod1 == prod2);
        }
        public static bool operator ==(Producto prod, string strProd)
        {
            if(prod.nombre.ToLower() == strProd.ToLower())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Producto prod, string strProd)
        {
            return !(prod == strProd);
        }
    }
}
