using System;

namespace EjemploDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumatoria = 0;
            int numero = 0;
            do
            {
                Console.Write("Ingrese un número:");
                numero = Convert.ToInt32(Console.ReadLine());

            } while (numero % 2 == 0);

            Console.WriteLine($"La sumatoria de los números es {sumatoria}");

            Console.Read();
        }
    }
}
