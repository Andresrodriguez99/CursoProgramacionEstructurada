using System;

namespace EjemploWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que suma los valores ingresados
            //mientras estos valores sean pares
            Console.Write("Ingrese un número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            int sumatoria = 0;

            while (numero % 2 == 0)
            {
                //Si es verdadero se ejecuta esto
                sumatoria = sumatoria + numero;

                Console.Write("Ingrese un número:");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            //Si es falso sigo acá abajo
            Console.WriteLine($"La sumatoria de los números es {sumatoria}");

            Console.Read();
        }
    }
}
