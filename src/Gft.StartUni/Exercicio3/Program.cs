using System;

namespace Exercicio3
{
    public static class Program
    {
        public static void Main()
        {

            if (!int.TryParse(Console.ReadLine(), out int intervaloInicial))
            {
                Console.WriteLine("Valor de entrada inválido.");
                return;
            }

            if (!int.TryParse(Console.ReadLine(), out int intervaloFinal))
            {
                Console.WriteLine("Valor de entrada inválido.");
                return;
            }

            if (intervaloFinal - intervaloInicial > 15)
            {
                Console.WriteLine("Intervalo inválido.");
                return;
            }

            for (int i = intervaloInicial; i < intervaloFinal; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
        }
    }
}