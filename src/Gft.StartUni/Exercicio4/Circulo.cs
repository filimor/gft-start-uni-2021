using System;

namespace Exercicio4
{
    internal class Circulo
    {
        public double Raio { get; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }
}