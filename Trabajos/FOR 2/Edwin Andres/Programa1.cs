using System;

namespace actividad
{
    class Program
    {
        static void Main(string[] args)
        {
            int  a, b, c, num;
            a = 0;
            b = 1;
            c = 1;
            num = 0;
            Console.WriteLine("Ingrese el numero hasta donde quiere que llegue");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El valor de 1 es: "+a);
            Console.WriteLine("El valor de 2 es: "+b);
            Console.WriteLine("El valor de 3 es: "+c);

            for (int i = 4; i <= num; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.WriteLine("El valor de: " +i+ "\n Es de: " + c);
            }

            Console.ReadLine();

        }
    }
}
