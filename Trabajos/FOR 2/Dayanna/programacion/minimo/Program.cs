using System;

namespace minimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int xa, yb ;
            int mayor, a ;
            Console.WriteLine("ingrese numero");
            xa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese segundo valor");
            yb = Convert.ToInt32(Console.ReadLine());
            mayor = xa ;
            if ( yb > mayor)
                mayor = yb ;
            a = mayor ;
            while ( ( a%xa!=0) || (a%yb!=0) )
                    a = a + 1 ;
            Console.WriteLine($"su resultado es : {a}" ) ;

        }
    }
}
