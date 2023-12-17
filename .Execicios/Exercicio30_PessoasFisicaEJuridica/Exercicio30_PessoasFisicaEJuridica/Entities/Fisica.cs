using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Exercicio30_PessoasFisicaEJuridica.Entities
{
    internal class Fisica : Pessoa
    {

        public double GastoSaude { get; set; }

        public Fisica(string name, double renda, double gastoSaude) : base(name, renda) 
        {
            GastoSaude = gastoSaude;
        }

        public override double Impostos()
        {
            double imposto;

            if (RendaAnual < 20000.00)
            {
                if (GastoSaude > 0.0)
                {
                    imposto = (RendaAnual * 0.15) - (GastoSaude / 2);
                }
                else
                {
                    imposto = RendaAnual * 0.15;
                }
            }
            else
            {
                if (GastoSaude > 0.0)
                {
                    imposto = (RendaAnual * 0.25) - (GastoSaude / 2);
                }
                else
                {
                    imposto = RendaAnual * 0.25;
                }
            }

            return imposto;
        }
    }
}
