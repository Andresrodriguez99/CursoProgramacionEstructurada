using System;

namespace Decisiones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese otro número:");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a < b)
            {
                //Si la condición se cumple                
                Console.WriteLine($"Excelente, {a} es menor que {b}");
            }
            else
            {
                //Si la condición NO se cumple
                if (a == b)
                {
                    //Si la condición se cumple
                    Console.WriteLine($"Bien, {a} es igual que {b}");
                }
                else
                {
                    //Si la condición NO se cumple
                    Console.WriteLine($"Bien, {a} es mayor que {b}");
                }
            }


            Console.Read();
        }
    }
}
