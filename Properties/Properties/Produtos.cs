using System;
using System.Globalization;

namespace Properties
{
    internal class Produtos
    {
        private string _nome;
        private double _preco;
        //Auto-Properties:
        //Atalho para criar uma properties -> 'prop' + tab
        public int Quantidade { get; private set; }

        public Produtos()
        {
        }

        public Produtos(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                    //O value entra no lugar do parametro.
                }
            }
            /*Quando a propertie tem uma logica interna, ela
            não pode ser criada como uma AutoProperties*/
        }

        public double Preco
        {
            get => _preco;
        }



        public double ValorTotalEstoque()
        {
            return _preco * Quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", R$" +
                _preco.ToString("f2", CultureInfo.InvariantCulture)
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
