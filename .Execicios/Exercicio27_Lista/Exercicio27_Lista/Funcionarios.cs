using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio27_Lista
{
    internal class Funcionarios
    {
        public int Id;
        public string Nome;
        public double Salario;

        public Funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentaSalario(double porcentagem)
        {
            if (porcentagem < 1)
            {
                Salario += Salario * porcentagem;
            }
            else
            {
                Salario += Salario * (porcentagem / 100.0);
            }
        }


        public override string ToString()
        {
            return Id + ", " + Nome + ", R$" + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
