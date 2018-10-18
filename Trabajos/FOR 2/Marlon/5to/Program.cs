using System;

namespace _5to
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese nro 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese nro 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            //Asignación
            int nromax = 0;
            int nromin = 0;

            //Desición
            if (a>b)
            {
                nromax = a;
                nromin = b;
            }
            else
            {
                nromax = b;
                nromin = a;
            }

            //Asignación
            
            int resul = 0;

            //do
           do
           {
               resul = b;
               b = a%b;
               a = resul;
           } while (b!=0);
            Console.WriteLine($"el maximo comun divisor es: {resul}");
        }
    }
}
