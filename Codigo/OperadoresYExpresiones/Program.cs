using System;

namespace OperadoresYExpresiones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int edad = 15;
            float peso = 90.5f;
            double salario = 1234567.4;
            string nombre = "Juan David";
            bool tieneEmpleo = true;

            //Expresiones matemáticas
            //Suma +, 
            //resta -, 
            //multiplicación *, 
            //división /, 
            //asignación =
            //módulo %
            int a = 8;
            int b = 9;
            int c = 10;
            int d = a + b * c / a - b * c;
            //Precedencia de Operadores
            //Parentesis
            //Mult, Divisi
            //Sum, Restas
            //Asignación

            //Expresiones booleanas
            bool esJueves = true;
            bool es30DeSeptiembre = true;
            bool esRecuperacion = false;
            bool tenemosParcial = esJueves && es30DeSeptiembre;
            bool tenemosQuiz = esJueves || esRecuperacion;

            // && AND (Y) V&&V=V
            // || OR (O)  F||F=F
            // ! NOT (Negación) !V=F
            // <,>,=<,>=,!=,==
            bool x = a < b;
            bool y = a != b;
            bool z = a == b;
            bool w = a > c && b < a || c != 8;
            bool t = (a > c && b < a) || c != 8;
            bool v = a > c && (b < a || c != 8);
            int año = 2018;
            char caracter = 'a';
            string cadena = "Hola mundo!";
            string saludo = cadena + " " + "Desde clase";//Concatenación
            string otroSaludo = saludo + " " + año;
            //Hola mundo! Desde clase2018

        }
    }
}
