using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int nnumero=0;
            int secondnumber =1;
            int x;
            int y;
            int count=0;

            {
                Console.WriteLine("Ingrese la cantidad de numeros que quiere de la serie fibonacci");
                x=Convert.ToInt32(Console.ReadLine());
                
                while(count<x)
                {
                    count=count+1;
                    y = nnumero;
                    nnumero = secondnumber;
                    secondnumber = y+nnumero;
                    
                    Console.WriteLine($"La serie de Fibonacci es {secondnumber}");
                   
                }

                

                Console.ReadLine();
            }
        }
    }
}
