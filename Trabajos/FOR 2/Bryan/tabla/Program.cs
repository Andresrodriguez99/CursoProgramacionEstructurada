using System;

namespace tabla
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string linea;
            Console.WriteLine("ingrese un multiplicador");
            linea = Console.ReadLine();
            n = Convert.ToInt32(linea);
            for (int i = 1 ; i <= 15 ; i ++)
            {
                Console.Write(i + " X " +n+" ="+i*n+"\n");
            }
            Console.ReadKey();
        }
    }
}
