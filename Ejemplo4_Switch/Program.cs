using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numero = 0;
            Console.WriteLine("IMPRESION DE NUMEROS EN LETRAS");
            Console.WriteLine("Ingrese un numero del 1 al 8");
            numero = Convert.ToInt32(Console.ReadLine());


            switch (numero)
            {
                case 1:
                    Console.WriteLine("uno");
                    break;
               case 2:
                    Console.WriteLine("dos");
                    break;
                case 3:
                    Console.WriteLine("tres");
                    break;

                case 4:
                    Console.WriteLine("cuatro");
                    break;
                case 5:
                    Console.WriteLine("cinco");
                    break;
                case 6:
                    Console.WriteLine("seis");
                    break;
                case 7:
                    Console.WriteLine("siete");
                    break;
                case 8:
                    Console.WriteLine("ocho");
                    break;
              
                default:
                    Console.WriteLine("El numero esta fuera del rango ");
                    break;
            }
            Console.Read();

        }
    }
}
