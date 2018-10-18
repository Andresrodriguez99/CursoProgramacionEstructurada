using System;

namespace _2do
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite nro base: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite exponente: ");
            int exp = Convert.ToInt32(Console.ReadLine());

            //Asignación
            int res = 1;
            int nrosumas = 0;

            //Mostrar
            Console.Write($"  <base>={b} <exponente>={exp}   ");

            //For
            for (int i = 0; i < exp; i++)
            {
                //Asignación
                res = res * b;

                //Condición
                if (i == exp-1)
                {
                    //Asignación
                Console.Write($"{b}");    
                }
                else{
                    //Asignación
                Console.Write($"{b}*");
                }
            }
            //Asignacion
            nrosumas = res/b;

            //Mostrar
                Console.Write($" = ");

            //For
            for (int i = 0; i < nrosumas; i++)
            {
                //Consición
                if (i == nrosumas-1)
                {
                    //Asignación
                Console.Write($"{b}");    
                }
                else{
                    //Asignación
                Console.Write($"{b}+");
                }
            }
            Console.Write($" = {res}");
            
        }
    }
}
