using System;

namespace _4to
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
            int nromin = 0;

            //Desición
            if (a>b)
            {
                nromin = a;
            }
            else
            {
                nromin = b;
            }

            //Asignación
            
            int resul = 0;

            //For
            for (int i = 1; i <= nromin; i++)
            {
                //desición
                if (a%i==0 && b%i==0)
                {
                    int nro = i;
                    resul = (a*b)/nro;
                }
            }
            Console.WriteLine($"el m.c.m es: {resul}");
        }
    }
}
