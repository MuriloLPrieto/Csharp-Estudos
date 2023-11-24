using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio24_Banco
{
    internal class Banco
    {
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public int Conta { get; private set; }
        
        public Banco(string nome, int conta) 
        {
            Titular = nome;
            Conta = conta;
        }
        public Banco(string nome, int conta, double depositoInicial) : this(nome, conta)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= (quantia + 5.0);
        }

        public override string ToString()
        {
            return "Dados "
                + Conta +
                ", Titular: "
                + Titular +
                ", Saldo: R$"
                + Saldo.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
