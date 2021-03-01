namespace Exercicio1
{
    public class Movel : Produto
    {
        public Movel(string nome, int quantidade, double valor) : base(nome, quantidade, valor)
        {
        }

        public override double CalcularValorFinal()
        {
            return Quantidade < 10
                ? Valor * Quantidade * 1.11
                : Valor * Quantidade * 1.05;
        }
    }
}