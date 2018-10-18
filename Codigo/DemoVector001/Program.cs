using System;

namespace DemoVector001
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración
            int[] vectorDeEnteros = new int[10];
            //[ , , , , , , , , , ]
            //Asignación de valores
            vectorDeEnteros[6] = 100;
            vectorDeEnteros[0] = 8;
            vectorDeEnteros[7] = 4;
            vectorDeEnteros[9] = 2;
            //LLenado (a través de un ciclo)
            Random aleatorio = new Random();
            for (int i = 0; i < 10; i++)
            {
                vectorDeEnteros[i] = aleatorio.Next(0,200);
            }
            //Lectura Manual
            Console.WriteLine(vectorDeEnteros[0]);
            Console.WriteLine(vectorDeEnteros[1]);
            Console.WriteLine(vectorDeEnteros[2]);
            Console.WriteLine(vectorDeEnteros[3]);
            Console.WriteLine(vectorDeEnteros[4]);
            Console.WriteLine(vectorDeEnteros[5]);
            Console.WriteLine(vectorDeEnteros[6]);
            Console.WriteLine(vectorDeEnteros[7]);
            Console.WriteLine(vectorDeEnteros[8]);
            Console.WriteLine(vectorDeEnteros[9]);
            //Lectura (a través de un ciclo)
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vectorDeEnteros[i]);
            }
            Console.Read();
        }
    }
}
