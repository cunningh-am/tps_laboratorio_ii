using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioNS
{
    public class Cliente:IMostrar
    {
        protected string nombre;
        protected string dni;

        public string Nombre
        {
            get{ return nombre; }
        }
        public string Dni
        { get { return dni;}
        }

        private Cliente()
        {

        }
        public Cliente(string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;

        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" █ NOMBRE: {this.nombre}");
            sb.AppendLine($" █ DNI:{this.dni}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return Mostrar();
        }
        //public void VaciarPedido()
        //{
        //    this.pedido.Clear();
        //}
        //public void AgregarAlPedido(Producto prod)
        //{
        //    this.pedido.Add(prod);
        //}
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if(c1.dni == c2.dni)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

    }
}
