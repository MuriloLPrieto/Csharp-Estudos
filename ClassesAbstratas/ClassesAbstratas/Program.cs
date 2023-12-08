﻿using ClassesAbstratas.Entities;
using System.Globalization;


List<Account> list = new List<Account>();

list.Add(new SavingAccount(1001, "Alex", 500.00, 0.01));
list.Add(new BussinessAccount(1002, "Maria", 500.0, 400.0));
list.Add(new SavingAccount(1004, "Bob", 500.0, 0.01));
list.Add(new BussinessAccount(1005, "Anna", 500.0, 500.0));

double sum = 0.0;

foreach (Account acc in list)
{
    sum += acc.Balance;
}

Console.WriteLine("Total balance: R$" + sum.ToString("F2", CultureInfo.InvariantCulture));

foreach (Account acc in list)
{
    acc.Withdraw(10.0);
}

foreach (Account acc in list)
{
    Console.WriteLine($"Updatd balance for account {acc.Number}: {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
}