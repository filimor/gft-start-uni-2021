using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio1
{
    public static class Caixa
    {
        public static void CalcularTotal(List<Produto> produtos)
        {
            foreach (var produto in produtos)
            {
                var sb = new StringBuilder()
                    .Append(produto.Nome)
                    .Append(" - R$ ")
                    .Append(produto.Valor.ToString("F2"))
                    .Append(" - ")
                    .Append(produto.Quantidade)
                    .Append(" Unidades - Total: ")
                    .Append(produto.CalcularValorFinal().ToString("F2"));

                Console.WriteLine(sb);
            }

            Console.WriteLine($"\nValor Total: R$ {produtos.Sum(p => p.CalcularValorFinal()):F2}");
        }
    }
}