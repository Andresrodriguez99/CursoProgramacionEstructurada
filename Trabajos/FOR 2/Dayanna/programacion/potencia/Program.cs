using System;

namespace potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado;
            Console.WriteLine("ingrese base");
            int o = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese valor para la potencia");
            int valor = Convert.ToInt32(Console.ReadLine());
            resultado=Math.Pow(o, valor);
            Console.WriteLine("la potencia de " + o + " elevada a " + valor + " su potencia es:" + resultado);
            Console.ReadLine();






        
        }
    }
}
