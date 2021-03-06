using System;

namespace Orientacao_Objeto_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable
            
            //Nullable<double> x = null;

            /*
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine();
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            Console.WriteLine();
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is Null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is Null");
            }
            */

            //Operador de coalescência nula

            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
            
            Console.ReadKey();
        }
    }
}
