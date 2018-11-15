using System;

namespace NotasDelEstudiante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*********Super software de notas*********************");
            Console.WriteLine("*****************************************************");

            Console.Write("Ingrese la cantidad de estudiantes del curso:");
            int cantidadEstudiantes = Convert.ToInt32(Console.ReadLine());
            string[] estudiantes = new string[cantidadEstudiantes];

            Console.Write("¿Cuantos cortes tiene el semestre?:");
            int cortes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la cantidad de notas por cada corte:");
            int notasPorCorte = Convert.ToInt32(Console.ReadLine());

            int cantidadColumnas = cortes * notasPorCorte + 1;
            double[,] notasFinales = new double[cantidadEstudiantes, cantidadColumnas];

            //Se llenan los nombres de los estudiantes
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.Write($"Ingrese el nombre del estudiante {i + 1}:");
                estudiantes[i] = Console.ReadLine();
                Console.WriteLine();
            }

            //Se pide cada nota
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                string estudianteEnProceso = estudiantes[i];
                Console.WriteLine($"Ingresando notas para el estudiante {estudianteEnProceso}");
                double promedioEstudiante = 0;
                for (int j = 0; j < cantidadColumnas; j++)
                {
                    //Esto indica si es la ultima columna
                    if (j == cantidadColumnas - 1)
                    {
                        notasFinales[i, j] = promedioEstudiante / (cortes * notasPorCorte);
                    }
                    else
                    {
                        Console.Write($"Nota {j + 1}:");
                        double nota = Convert.ToDouble(Console.ReadLine());
                        notasFinales[i, j] = nota;
                        promedioEstudiante += nota;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Resultados finales:");
            //Se imprime el resultado final
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                string estudianteEnProceso = estudiantes[i];
                Console.Write(estudianteEnProceso + " ");
                for (int j = 0; j < cantidadColumnas; j++)
                {
                    Console.Write(notasFinales[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
