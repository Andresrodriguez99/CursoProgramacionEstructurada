using System;

namespace actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, resultado;

            Console.WriteLine("Ingrese la base de la potencia: ");
            x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Ingrese el numero de elevacion: ");
            y = Convert.ToInt32(Console.ReadLine());

            resultado = Math.Pow(x, y);
            
            Console.WriteLine($"El resultado de la potencia es: {resultado}");

            Console.ReadLine();



        }
    }
}
