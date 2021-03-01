namespace Exercicio1
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }

        public Produto(string nome, int quantidade, double valor)
        {
            Nome = nome;
            Quantidade = quantidade;
            Valor = valor;
        }

        public virtual double CalcularValorFinal()
        {
            return Valor * Quantidade * 1.1;
        }
    }
}