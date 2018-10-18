using System;

namespace Mínimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            int w;

            Console.Write("Ingrese un número: ");
            x=Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese otro número: ");
            y=Convert.ToInt32(Console.ReadLine());

            z=x;

            if(y>z)
            {
                z=y;
            }
            w=z;
            while((w%x!=0) || (w%y!=0))
            {
                w=w+1;
            }
            Console.Write($"El Mínimo Común Divisor es: {w}");


            Console.ReadLine();
        }
    }
}
