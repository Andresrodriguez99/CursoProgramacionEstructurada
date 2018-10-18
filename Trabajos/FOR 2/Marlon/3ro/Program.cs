using System;

namespace _3ro
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            Console.Write("Digite nro a hallar tabla de multiplicar hasta el 10: ");
            int nro = Convert.ToInt32(Console.ReadLine());

            //For
            for (int i = 0; i < 11; i++)
            {
                //Asignación
                op = nro * i;
                Console.WriteLine($"  {nro} * {i} = {op}");
            }
        }
    }
}
