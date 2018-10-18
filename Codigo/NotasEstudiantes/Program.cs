using System;

namespace NotasEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que permite calcular el promedio
            //de las notas ingresadas
            Console.Write("Ingrese la cantidad de notas:");
            int cantidadNotas = Convert.ToInt32(Console.ReadLine());

            double[] notas = new double[cantidadNotas];

            //Llenar el vector de las notas
            for (int i = 0; i < notas.Length; i++)
            {
                double notaIngresada = -1;
                do
                {
                    Console.Write($"Ingrese la nota {i + 1}:");
                    notaIngresada = Convert.ToDouble(Console.ReadLine());

                    if (notaIngresada >= 0 && notaIngresada <= 5)
                    {
                        notas[i] = notaIngresada;
                    }
                    else
                    {
                        Console.WriteLine("Intentelo de nuevo, debe ser mayor a 0 y menor igual a 5");
                    }
                } while (notaIngresada < 0 || notaIngresada > 5);
            }

            //Recorremos el vector para calcular el promedio
            double promedio = 0;
            double sumatoria = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                sumatoria = sumatoria + notas[i];
            }
            promedio = sumatoria / notas.Length;

            Console.WriteLine($"El promedio es {promedio}");
            if (promedio < 3)
            {
                Console.WriteLine("Nos vemos el proximo");
            }
            else
            {
                Console.WriteLine("Tambien nos vemos el proximo pero en otra materia");
            }
            Console.Read();
        }
    }
}
