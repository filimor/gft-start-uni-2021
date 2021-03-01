using System;

namespace Exercicio2
{
    public static class Program
    {
        public static void Main()
        {
            for (int i = 10; i <= 215; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}