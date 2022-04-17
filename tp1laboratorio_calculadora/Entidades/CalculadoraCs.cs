using System;

namespace Entidades
{
    public static class CalculadoraCs // tuve que cambiar el nombre de Calculadora a CalculadoraCs porque el compilador se la confundia con el form a la hora de invocar la funcion operar.
    {
        /// <summary>
        /// Valida que el operador sea un caracter de operador valido
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns> en caso de que no sea un caracter valido, lo retorna como un '+'
        private static char ValidarOperador(char operador) 
        {
            switch(operador)
            {
                case '-':
                    return '-';
                case '/':
                    return '/';
                case '*':
                    return '*';
                default:
                    return '+';
            }
        }
        /// <summary>
        /// Se encarga de operar entre objetos del tipo Operando dependiendo del operador que reciba y manejando excepcionalmente la division por cero.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado;

            switch (operador)
            {
                case '-':
                    resultado = num1 - num2;
                    return resultado;
                case '/':
                    if(num2==0)
                    {
                        return double.MinValue;
                    }
                    resultado = num1 / num2;
                    return resultado;
                case '*':
                    resultado = num1 * num2;
                    return resultado;
                default:
                    resultado = num1 + num2;
                    return resultado;
            }
        }
    }
}
