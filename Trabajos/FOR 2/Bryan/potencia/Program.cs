using System;

namespace potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado;
            Console.WriteLine("ingrese base");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese valor para la potencia");
            int valor = Convert.ToInt32(Console.ReadLine());
            resultado=Math.Pow(n, valor);
            Console.WriteLine("la potencia de " + n + " elevada a " + valor + " su potencia es:" + resultado);
            Console.ReadLine();






        
        }
    }
}
