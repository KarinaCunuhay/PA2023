using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo5_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limiteSuperior = 20, contador = 1;
            Console.WriteLine("IMPRIMIR NUMEROS DEL 1 AL 20");
            while (contador <= limiteSuperior)
            {
                Console.WriteLine("Valor: {0}", contador);
                contador++;
            }
            Console.Read();
        }
    }
}
