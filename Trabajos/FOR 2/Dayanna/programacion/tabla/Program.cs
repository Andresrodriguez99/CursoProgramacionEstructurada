using System;

namespace tabla
{
    class Program
    {
        static void Main(string[] args)
        {
            int e;
            string linea;
            Console.WriteLine("ingrese un multiplicador");
            linea = Console.ReadLine();
            e = Convert.ToInt32(linea);
            for (int i = 1 ; i <= 15 ; i ++)
            {
                Console.Write(i + " X " +e+" ="+i*e+"\e");
            }
            Console.ReadKey();
        }
    }
}
