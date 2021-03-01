using System.Collections.Generic;

namespace Exercicio1
{
    public static class Program
    {
        private static void Main()
        {
            var produtos = new List<Produto>
            {
                new Eletronico("Ventilador",3,320.00),
                new Eletronico("Comptuador",2,3999.00),
                new Movel("Mesa",2,270.00),
                new Produto("Caderno",10,10.50),
                new Movel("Cadeira", 2,234.24),
                new Produto("Caneta",15,0.70)
            };

            Caixa.CalcularTotal(produtos);
        }
    }
}