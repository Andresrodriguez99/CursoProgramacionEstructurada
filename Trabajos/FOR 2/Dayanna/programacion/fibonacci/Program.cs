using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int e, r, t, y, x ;
            Console.WriteLine("¿cuantos numeros quieres?");
            t = Convert.ToInt32(Console.ReadLine());
            e = 0 ;
            r = 1 ;
            for (y = 0 ; y < t ; y ++)
            {
                x = e ;
                e = r ;
                r = x + e ;
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
