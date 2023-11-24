using System;
using System.Globalization;

namespace Construtores
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtores normalmente são colocados depois dos atributos
        public Produto(string nome, double preco, int quantia)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantia;
        }

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", R$" +
                Preco.ToString("f2", CultureInfo.InvariantCulture)
                + ", " +
                Quantidade
                + " unidades, total: R$" +
                ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        public void AdicionarProdutos(int quantia)
        {
            Quantidade += quantia;
        }

        public void RemoverProdutos(int quantia)
        {
            Quantidade -= quantia;
        }
    }
}
