using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{ 
     public class Operando
    {
        private double numero;
        /// <summary>
        /// Constructores del tipo operando preparados para construir un objeto recibiendo como parametro ya sea un double, un string, o ninguno
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
        public Operando() : this(0)
        {
        }
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        /// <summary>
        /// se encarga de validar si un numero enviado como parametro de tipo string es un operando valido
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns> en caso de ser un numero valido, lo parsea a double y lo retorna, en caso de que no lo sea, retorna 0
        private double ValidarOperando(string strNumero)
        {
            double numero = 0;
            if (strNumero is not null)
            {
                Double.TryParse(strNumero, out numero);
            }
            return numero;

        }
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }
        #region sobrecarga de operadores
        // Sobrecarga de operadores aritmeticos y de comparacion para poder trabajar con el valor numerico del objeto Operando
        public static double operator + (Operando num1, Operando num2)
        {
            return num1.numero + num2.numero;
        }
        public static double operator - (Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }
        public static double operator / (Operando num1, Operando num2)
        {
            return num1.numero / num2.numero;
        }
        public static double operator * (Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }
        public static bool operator ==(Operando num1,double num2)
        {
            return num1.numero == num2;
        }
        public static bool operator !=(Operando num1, double num2)
        {
            return num1.numero == num2;
        }
        #endregion
        #region funciones binarias
        /// <summary>
        /// recibe un string y se encarga de comprobar si se compone unicamente de caracter '0' o '1' 
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns> retorna false en caso de que encuentre un caracter distinto a 0 o 1
        private static bool EsBinario(string binario)
        {
            foreach(char c in binario)
            {
                if(c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// recibe un numero double y en caso de ser positivo lo convierte a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns> retorna el numero binario en formato string, en el caso de no poder convertirlo retorna "valor invalido"
        public static string DecimalBinario(double numero)
        {
            if (numero >= 0)
            {
                return Convert.ToString((Int32)numero, 2);
            }

            return "Valor invalido";
        }
        /// <summary>
        /// recibe un numero en formato string y utiliza la funcion de arriba para pasarlo a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns> en caso de no poder parsear, retorna valor invalido, en caso de poder retorna el numero binario en string
        public static string DecimalBinario(string numero)
        {
            double numDouble;

            if (double.TryParse(numero, out numDouble))
            {
                return DecimalBinario(numDouble);
            }
            else
            {
                return "Valor inválido";
            }
     
        }
        /// <summary>
        /// recibe un string de un numero binario para ser convertido a un entero decimal siempre y cuando el string recibido sea binario (verificado por EsBinario())
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns> una vez termina de operar retorna el resultado en un string, en caso de que no sea un binario valido retorna "valor invalido"
        public static string BinarioDecimal(string binario)
        {
            if(EsBinario(binario))
            {
                int numDecimal = Convert.ToInt32(binario, 2);
                return Convert.ToString(numDecimal);
            }
            return "Valor invalido";
        }
    }
}
#endregion