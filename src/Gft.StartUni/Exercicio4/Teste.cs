using System;

namespace Exercicio4
{
    public static class Teste
    {
        public static void Main()
        {
            var quadrado = new Quadrado(15.2);
            var retangulo = new Retangulo(23.5, 19.1);
            var circulo = new Circulo(8.73);

            Console.WriteLine($"Área do Quadrado: {quadrado.CalcularArea():F3}");
            Console.WriteLine($"Área do Retângulo: {retangulo.CalcularArea():F3}");
            Console.WriteLine($"Área do Círculo: {circulo.CalcularArea():F3}");
        }
    }
}