using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio30_PessoasFisicaEJuridica.Entities
{
    internal class Juridica : Pessoa
    {

        public int NumeroFuncionarios { get; set; }

        public Juridica(string name, double renda, int numeroFuncionarios) : base(name, renda)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double Impostos()
        {
            double imposto = RendaAnual * 0.16;

            if (NumeroFuncionarios > 10)
            {
                imposto = RendaAnual * 0.14;
            }

            return imposto;
        }
    }
}
