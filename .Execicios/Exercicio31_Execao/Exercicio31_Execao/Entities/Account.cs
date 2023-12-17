using System;
using System.Globalization;
using Exercicio31_Execao.Entities.Exceptions;

namespace Exercicio31_Execao.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }

        public double Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Withdraw amount is more than total balance!");
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Withdraw limit is less than withdraw amount!");
            }

            return Balance -= amount;
        }
    }
}
