using System;
using System.Globalization;
using Exercicio31_Execao.Entities;
using Exercicio31_Execao.Entities.Exceptions;

bool condicao = false;

while (condicao == false)
{
    try
    {
        Console.WriteLine("Enter account data: ");
        Console.Write("Number: ");
        int accountNumber = int.Parse(Console.ReadLine());
        Console.Write("Holder: ");
        string holder = Console.ReadLine();
        Console.Write("Initial Balance: ");
        double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("WithDraw Limit: ");
        double withdrawAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Account account = new Account(accountNumber, holder, initialBalance, withdrawAmount);

        Console.WriteLine();
        Console.Write("Enter amount for withdraw: ");
        double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        account.Withdraw(withdraw);

        Console.WriteLine("");
        Console.WriteLine("New Balance: R$" + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
        condicao = true;
    }
    catch (DomainException e)
    {
        Console.WriteLine();
        condicao = false;
        Console.WriteLine("WithDraw error: " + e.Message);
        Console.WriteLine("Pressione Enter:");
        Console.ReadKey();
        Console.Clear();
    }
    catch (Exception e)
    {
        Console.WriteLine();
        condicao = false;
        Console.WriteLine("Generic error: " + e.Message);
        Console.WriteLine("Pressione Enter:");
        Console.ReadKey();
        Console.Clear();
    }
}