using System;

namespace EjemploFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio0();
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Console.Read();
        }
        public static void Ejercicio0()
        {

            //Calcular la sumatoria de los números pares y de los números impares
            //Hasta un número X
            Console.WriteLine("*************************");
            Console.WriteLine("Sumatoria de pares e impares");
            Console.WriteLine("*************************");
            int numero = 100;
            int sumatoriaPares = 0;
            int sumatoriaImpares = 0;


            for (int i = 0; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    sumatoriaPares += i;
                }
                else
                {
                    sumatoriaImpares += i;
                }
            }

            Console.WriteLine($"La sumatoria de los pares hasta {numero} es {sumatoriaPares}");
            Console.WriteLine($"La sumatoria de los impares hasta {numero} es {sumatoriaImpares}");

        }
        public static void Ejercicio1()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine("Multiplicacion por sumas sucesivas");
            Console.WriteLine("*************************");
            int a = 8;
            int b = 10;
            int sumatoria = 0;

            for (int i = 0; i < b; i++)
            {
                sumatoria += a;
            }

            Console.WriteLine($"{a}x{b}={sumatoria}");
        }


        public static void Ejercicio2()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine("División entera entre dos números ingresados");
            Console.WriteLine("*************************");
            int a = 98;
            int b = 10;
            int cociente = 0;

            for (int i = a; i >= 0; i -= b)
            {
                cociente++;
            }

            Console.WriteLine($"{a}/{b}={cociente}");
        }



        public static void Ejercicio3()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine("Factorial de un número ingresado");
            Console.WriteLine("*************************");
            int a = 5;
            double factorial = 1;

            for (int i = 1; i <= a; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial de {a} es {factorial}");
        }

        public static void Ejercicio4()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine("Sumatoria primos hasta un número");
            Console.WriteLine("*************************");
            int numero = 100;

            int sumatoria = 0;

            for (int i = 1; i <= numero; i++)
            {
                bool esPrimo = true;
                for (int j = 2; j <= (i / 2); j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break; //Si encontramos que tiene un divisor se termina
                    }
                }
                if (esPrimo)
                {
                    Console.Write(i + " ");
                    sumatoria += i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"La sumatoria de los números hasta {numero} es {sumatoria}");
        }
    }
}
