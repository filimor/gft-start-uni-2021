namespace Exercicio4
{
    internal class Quadrado
    {
        public double Lado { get; }

        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public double CalcularArea()
        {
            return Lado * Lado;
        }
    }
}