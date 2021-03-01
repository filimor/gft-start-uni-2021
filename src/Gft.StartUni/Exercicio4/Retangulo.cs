namespace Exercicio4
{
    internal class Retangulo
    {
        public double Largura { get; }
        public double Altura { get; }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double CalcularArea()
        {
            return Largura * Altura;
        }
    }
}