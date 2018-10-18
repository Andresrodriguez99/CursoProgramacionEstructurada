using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, x ;
            Console.WriteLine("¿cuantos numeros quieres?");
            c = Convert.ToInt32(Console.ReadLine());
            a = 0 ;
            b = 1 ;
            for (d = 0 ; d < c ; d ++)
            {
                x = a ;
                a = b ;
                b = x + a ;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
