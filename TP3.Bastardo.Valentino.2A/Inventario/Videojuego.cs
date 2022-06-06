using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioNS
{
    public class Videojuego:Producto,IMostrar
    {
        protected TipoConsola paraConsola;
        protected Genero genero;

        public Genero Genero
        {
            get { return genero; }
            set { this.genero = value; }
        }
        public TipoConsola ParaConsola
        {
            get { return paraConsola; }
            set { this.paraConsola = value; }
        }
        public Videojuego()
        {

        }
        public Videojuego(Producto prod, TipoConsola tipo, Genero genero):this(prod.Nombre,prod.Precio,prod.UnidadesVendidas,tipo,genero)
        {

        }
        public Videojuego(string nombre, float precio, int unidadesVendidas, TipoConsola tipo, Genero genero):base(nombre,precio, unidadesVendidas)
        {
            this.paraConsola = tipo;
            this.genero = genero;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($" █ GENERO: {this.genero}");
            sb.AppendLine($" █ PARA LA CONSOLA:{this.paraConsola}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return Mostrar();
        }
        /// <summary>
        /// Compara si dos videojuegos son el mismo, unicamente siendo iguales cuando comparten nombre Y PLATAFORMA 
        /// ya que mismo juego puede salir para distintas plataformas
        /// </summary>
        /// <param name="vj1"></param>
        /// <param name="vj2"></param>
        /// <returns></returns>
        public static bool operator ==(Videojuego vj1, Videojuego vj2)
        {
            if (vj1.paraConsola == vj2.paraConsola && vj1.nombre.ToLower() == vj2.nombre.ToLower())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Videojuego vj1, Videojuego vj2)
        {
            return !(vj1 == vj2);
        }
    }
}
