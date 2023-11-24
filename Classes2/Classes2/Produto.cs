using System;
using System.Globalization;

namespace Classes2
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

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
