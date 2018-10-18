using System;

namespace maximo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ingrese dato");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese otro dato");
            int b = Convert.ToInt32(Console.ReadLine());

            int x = Math.Max(a, b);
            int y = Math.Min(a, b);
            int res;

            do {
                res = y;
                y = x%y;
                x = res;
            }while(y!=0);

            Console.WriteLine($"El resuldado del MCD es igual a {res}");
            Console.ReadKey(true);
        }
    }
}
