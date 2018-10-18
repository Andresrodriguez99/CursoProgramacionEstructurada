using System;

namespace actividad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,mcm,mcd,r;

           do { 
            Console.WriteLine("Ingrese el primer numero: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            b = Convert.ToInt32(Console.ReadLine());

            } 
            while (a<0 && b<0);

            mcd = a;
            r = b;
            do {
                c = mcd % r ;
                mcd = r;
                r = c;
            }
            while(r!=0);

            mcm = a * b /  mcd;

            Console.WriteLine($"El MCD es: {mcd}");
            Console.WriteLine($"El MCM es: {mcm}");

            Console.ReadLine();

        }
    }
}
