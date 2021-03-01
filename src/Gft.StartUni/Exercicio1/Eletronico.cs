namespace Exercicio1
{
    public class Eletronico : Produto
    {
        public Eletronico(string nome, int quantidade, double valor) : base(nome, quantidade, valor)
        {
        }

        public override double CalcularValorFinal()
        {
            return Valor * Quantidade * 1.15;
        }
    }
}