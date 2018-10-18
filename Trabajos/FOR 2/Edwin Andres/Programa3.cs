using System;

namespace actividad3
{
    class Program
    {
        static void Main(string[] args)
        {
           int r;

            Console.WriteLine("Ingrese el numero que desea multiplicar");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<=12; i++)
            {
                r = num * i;
                Console.WriteLine(num + " x " + i + " = " + r);
            }
    
            Console.ReadLine();

        }
    }
}
