using System;

namespace maximo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ingrese dato");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese otro dato");
            int y = Convert.ToInt32(Console.ReadLine());

            int a = Math.Max(x, y);
            int b = Math.Min(x, y);
            int res;

            do {
                res = b;
                b = a%b;
                a = res;
            }while(b!=0);

            Console.WriteLine($"El resuldado del MCD es igual a {res}");
            Console.ReadKey(true);
        }
    }
}
