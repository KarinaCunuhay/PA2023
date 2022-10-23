using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2_Condicional_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operador Condicional
            //Compra >=200  => recargo 12%
            //Compra >=100  => recargo 10%

            float valorCompra = 0, recargo = 0;
            Console.WriteLine("Ingrese el valor de la compra: ");
            valorCompra = Convert.ToInt32(Console.ReadLine());

            if (valorCompra>=200)
            {
                recargo = valorCompra * 0.12f;
            }
            else
            {
                recargo = 0;
            }


            Console.WriteLine("Recargo a pagar es: $ {0} ", recargo);
            Console.Read();

        }
        
    }
}
