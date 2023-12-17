using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio30_PessoasFisicaEJuridica.Entities
{
    abstract class Pessoa
    {
        public string Name { get; set; }
        public double RendaAnual { get; set; }

        public Pessoa() { }

        public Pessoa(string name, double renda) 
        {
            Name = name;
            RendaAnual = renda;
        }

        public abstract double Impostos();
    }
}
