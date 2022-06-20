using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioNS
{
    public class Inventario:IMostrar,IListar<Producto>
    {
        protected List<Producto> inventarioEnStock;
        protected string razonSocial;
        public List<Producto> Lista    
        {
            get{ return this.inventarioEnStock; }
            set{ this.inventarioEnStock = value; }
        
        }
        public double GananciasPorJuegosDePlay2
        {
            get
            {
                return this.CalcularGananciaJuegos(TipoConsola.PS2);
            }
        }
        public double GananciasPorJuegosDeGameCube
        {
            get
            {
                return this.CalcularGananciaJuegos(TipoConsola.GameCube);
            }
        }
        public double GananciasPorConsolasPs2
        {
            get
            {
                return this.CalcularGananciaConsolas(TipoConsola.PS2);
            }
        }
        public double GananciasPorConsolasGameCube
        {
            get
            {
                return this.CalcularGananciaConsolas(TipoConsola.GameCube);
            }
        }
        public double GananciasTotales
        {
            get
            {
                return (this.CalcularGananciaConsolas(TipoConsola.GameCube) +
                        this.CalcularGananciaConsolas(TipoConsola.PS2) +
                        this.CalcularGananciaJuegos(TipoConsola.GameCube) +
                        this.CalcularGananciaJuegos(TipoConsola.PS2));
            }
        }

        public Inventario()
        {
            inventarioEnStock = new List<Producto>();
        }
        public Inventario(string razon) : this()
        {
            razonSocial = razon;
        }
        
        private double CalcularGananciaConsolas(TipoConsola tipo)
        {
            double recaudado = 0;
            foreach (Producto prod in this.inventarioEnStock)
            {
                if (prod is not Consola)
                {
                    continue;
                }
                if ((prod is PlayStation2 && tipo == TipoConsola.PS2) || (prod is GameCube && tipo == TipoConsola.GameCube))
                {
                    recaudado += (double)prod.Precio * prod.UnidadesVendidas;
                }
            }
            return recaudado;
        }
        private double CalcularGananciaJuegos(TipoConsola tipo)
        {
            double recaudado = 0;
            foreach (Producto prod in this.inventarioEnStock)
            {
                if (prod is not Videojuego)
                {
                    continue;
                }
                if (((Videojuego)prod).ParaConsola == tipo)
                {
                    recaudado += (double)prod.Precio * prod.UnidadesVendidas;
                }
            }
            return recaudado;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"RAZON SOCIAL: {this.razonSocial}");
            sb.AppendLine($"----------GANANCIAS------------");
            sb.AppendLine($"POR VENTA DE CONSOLAS GAMECUBE: ${this.GananciasPorConsolasGameCube}");
            sb.AppendLine($"JUEGOS DE GAMECUBE: ${this.GananciasPorJuegosDeGameCube}");
            sb.AppendLine($"POR VENTA DE CONSOLAS PLAYSTATION2:$ {this.GananciasPorConsolasPs2}");
            sb.AppendLine($"JUEGOS DE PLAYSTATION2: ${this.GananciasPorJuegosDePlay2}");
            sb.AppendLine($"GANANCIAS TOTALES: ${this.GananciasTotales}");

            return sb.ToString();
        }
        public string MostrarInventario()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("------------INVENTARIO-----------");
            foreach (Producto prod in inventarioEnStock)
            {
                sb.AppendLine(prod.ToString());
            }
            sb.AppendLine("--------------------------------");

            return sb.ToString();
        }
        public override string ToString()
        {
            return Mostrar();
        }
        private void AgregarProducto(Producto nuevoProd)
        {
            if (nuevoProd is not null)
            {
                this.inventarioEnStock.Add(nuevoProd);
            }
        }
        /// <summary>
        /// sobrecarga del operador de igualdad para chequear si un producto ya existe dentro de la lista de productos del inventario
        /// </summary>
        /// <param name="i"></param>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static bool operator ==(Inventario i, Producto prod)
        {
            foreach (Producto auxProd in i.inventarioEnStock)
            {
                if (prod is Videojuego)
                {
                    if (auxProd is not Videojuego)
                    {
                        continue;
                    }
                    if (((Videojuego)auxProd) == ((Videojuego)prod))
                    {
                        return true;
                    }

                }
                else
                {
                    if (auxProd is not Consola)
                    {
                        continue;
                    }
                    if (((Consola)auxProd) == ((Consola)prod))
                    {
                        return true;
                    }

                }
            }
            return false;
        }
        /// <summary>
        /// en caso de ya encontrarse en la lista el producto que se esta intentando agregar, lanza una InventarioException
        /// </summary>
        /// <param name="i"></param>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static bool operator !=(Inventario i, Producto prod)
        {
            return !(i == prod);
        }
        public static Inventario operator +(Inventario i, Producto nuevoProd)
        {

            if (i != nuevoProd)
            {
                i.AgregarProducto(nuevoProd);
            }
            else
            {
                throw new InventarioException("Ese producto ya se encuentra en el inventario", "Inventario", "Operador +");
            }
            return i;

        }
    }
}
