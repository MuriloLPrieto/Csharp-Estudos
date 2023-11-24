using System;
using System.Globalization;

namespace Sobrecarga
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            //Para poder utilizar o construtor padrão sem precisar 
            //atribuir valores
            Quantidade = 10;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) : this() //referenciando um
            //construtor dentro de outro com this()
        {
            Nome = nome;
            Preco = preco;
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
