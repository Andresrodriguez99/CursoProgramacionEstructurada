using System;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            string linea;

            Console.WriteLine("Ingrese un multiplo");
            linea = Console.ReadLine();

            x = Convert.ToInt32(linea);

            for (int i = 1 ; i <= 10 ; i ++)
            {
                Console.WriteLine(i + " * " +x+" ="+i*x+"");
            }
            Console.ReadKey();
        }
    }
}
