using System;

namespace minimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y ;
            int mayor, a ;
            Console.WriteLine("ingrese numero");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese segundo valor");
            y = Convert.ToInt32(Console.ReadLine());
            mayor = x ;
            if ( y > mayor)
                mayor = y ;
            a = mayor ;
            while ( ( a%x!=0) || (a%y!=0) )
                    a = a + 1 ;
            Console.WriteLine($"su resultado es : {a}" ) ;

        }
    }
}
