using System;

namespace Máximo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite otro número: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int w = Math.Max(x, y);

            int v = Math.Min(x, y);

            int r;

            do 
            {
                r = v;
                v = w%v;
                w = r;
            }
            while(v!=0);

            Console.Write($"El Máximo Común Divisor de sus números es:  {r}");

            Console.ReadLine();
        }
    }
}
