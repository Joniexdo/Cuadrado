using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevaralcuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variabkes
            int number;
            bool error;
            do
            {
                try
                {
                    error = false;
                    Console.Write("Enter number: ");
                    number = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + Math.Pow(number, 2));
                }
                catch (FormatException e)
                {
                    error = true;
                    Console.WriteLine("Solo se aceptan numeros enteros y no letras");
                    Console.WriteLine(e.Message);

                }
                catch (OverflowException e)
                {
                    error = true;
                    Console.WriteLine("Valor no soportado");
                    Console.WriteLine(e.Message);
                }
            } while (error == true);
            Console.WriteLine("Presione enter para continuar");
            Console.ReadKey();
        }
    }
}
