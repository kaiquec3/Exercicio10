using System;

namespace Exercício_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Terreno();
            double k;

            do
            {
                Console.Write("Informe o valor da base: ");
                k = double.Parse(Console.ReadLine());

                if (k > 0) a1.SetBase(k);
            }
            while (k <= 0);

            do
            {
                Console.Write("Informe o valor da altura: ");
                k = double.Parse(Console.ReadLine());

                if (k > 0) a1.SetAltura(k);
            }
            while (k <= 0);

            Console.WriteLine($"A área do terreno é {a1.CalcularArea()}\nTerreno {a1.DimensionarTerreno()}");
        }
    }
}
