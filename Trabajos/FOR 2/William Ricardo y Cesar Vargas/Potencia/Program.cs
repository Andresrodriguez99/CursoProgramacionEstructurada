using System;

namespace Potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
              double respuesta;
              

              Console.WriteLine("Ingrese el primer número ");
              int b = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("Ingrese la potencia a la cual desea elevar");
              int p = Convert.ToInt32(Console.ReadLine());

              respuesta=Math.Pow(b,p);

              Console.WriteLine($"su potencia es: {respuesta}");
                
            Console.ReadLine();

            }
        }
    }
}
