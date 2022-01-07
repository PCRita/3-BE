using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_InterfaceCalculator
{

    class Program
    {

        static void Main(string[] args)
        {
            SimpleCalculator simpleCalculator01 = new SimpleCalculator();
            ScientificCalculator scientificCalculator01 = new ScientificCalculator();

            Console.WriteLine(simpleCalculator01.Somar(1, 2));
            Console.WriteLine(simpleCalculator01.Somar(1, 2, 3));
            Console.WriteLine(simpleCalculator01.Subtrair(1, 2));
            Console.WriteLine(simpleCalculator01.Multiplicar(1, 2));
            Console.WriteLine(simpleCalculator01.Multiplicar(1, 2, 3));
            Console.WriteLine(simpleCalculator01.Multiplicar(1, 2, 3, 4));
            Console.WriteLine(simpleCalculator01.Dividir(1, 2));


            Console.WriteLine("\n");

            Console.WriteLine(scientificCalculator01.Somar(1, 2));
            Console.WriteLine(scientificCalculator01.Subtrair(1, 2));
            Console.WriteLine(scientificCalculator01.Multiplicar(1, 2));
            Console.WriteLine(scientificCalculator01.Dividir(1, 2));
            Console.WriteLine(scientificCalculator01.RaizQuadrada(1));
            Console.WriteLine(scientificCalculator01.ValorAbsoluto(-11));

            Console.ReadKey();
        }

    }

}
