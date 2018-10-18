using System;

namespace _1ro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite cantidad de números a mostrar de la secuencia: ");
            int nro = Convert.ToInt32(Console.ReadLine());

            //Asignación
            int an = 1;
            int ac = 0;
            int t = 0;

            //For
            for (int i = 0; i < nro; i++)
            {
                //Asignación
                int c = an;
                an = t;
                ac = c;
                t = an + ac;

                //Mostrar Nros
                Console.Write($"  {t}");
            }
        }
    }
}
