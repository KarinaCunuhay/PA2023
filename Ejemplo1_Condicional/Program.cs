using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operador Condicional
            //Compra >=200  => recargo 12%
            //Compra >=100  => recargo 10%

            float valorCompra = 0, recargo = 0;
            Console.Write("ingrese el valor de la compra: ");
            valorCompra = Convert.ToSingle(Console.ReadLine());

            //caso1
            //recargo = valorCompra >= 200 ? (valorCompra * 0.12f) : 0;

            //caso2
            recargo = valorCompra >= 200 ? (valorCompra * 0.12f) : valorCompra >= 100 ? (valorCompra * 0.1f) : 0;



            Console.WriteLine("El valor a pagar es: $ "+ recargo); //concatenar

            Console.Read();
        }
    }
}
