using System;

namespace ConvertYConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clase Console
            //Se encarga del trabajo con la consola de comandos

            //Escribir contenido
            Console.Write("Texto 1");
            Console.WriteLine("Texto 2");

            Console.ForegroundColor = ConsoleColor.Green;
            //Leer contenido
            Console.Write("Ingrese su nombre:");
            Console.ForegroundColor = ConsoleColor.White;

            string nombres = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Ingrese su apellido:");
            Console.ForegroundColor = ConsoleColor.White;
            string apellidos = Console.ReadLine();

            Console.Write("Ingrese el año de nacimiento:");
            string añoNacimiento = Console.ReadLine();

            //Convert
            int año = Convert.ToInt32(añoNacimiento);
            int edad = 2018 - año;

            Console.WriteLine(nombres + " " + apellidos + " su edad es " + edad);

            Console.Read();
        }
    }
}
