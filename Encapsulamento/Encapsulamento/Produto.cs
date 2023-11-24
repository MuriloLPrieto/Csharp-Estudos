using System;
using System.Globalization;

namespace Encapsulamento
{
    internal class Produto
    {
        private string _nome; //privados comecam com o " _ " e letra minuscula
        private double _preco;
        private int _quantidade;

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Metodos Get e Set
        public string GetNome()
        {
            //O Get pega os dados privates e permite o uso sem alterar
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                //O Set permite alterações nos dados.
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEstoque()
        {
            return _preco * _quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", R$" +
                _preco.ToString("f2", CultureInfo.InvariantCulture)
                + ", " +
                _quantidade
                + " unidades, total: R$" +
                ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        public void AdicionarProdutos(int quantia)
        {
            _quantidade += quantia;
        }

        public void RemoverProdutos(int quantia)
        {
            _quantidade -= quantia;
        }
    }
}
