using Exercicio24_Banco;
using System.Globalization;
using System.Net.WebSockets;

Console.Write("Entre com o número da conta: ");
int contaBancaria = int.Parse(Console.ReadLine());

Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();

Console.Write("Haverá depósito inicial (S/N)? ");
char confirmacao = char.Parse(Console.ReadLine().ToLower());

Banco pessoa;

if (confirmacao == 's')
{
    Console.Write("Entre o valor de Deposito: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    pessoa = new Banco(titular, contaBancaria, depositoInicial);
}
else
{
    pessoa = new Banco(titular, contaBancaria);
}

Console.WriteLine();
Console.WriteLine("Dados da conta:");
Console.WriteLine(pessoa);

Console.WriteLine();

Console.Write("Entre com um valor para deposito: ");
pessoa.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(pessoa);

Console.WriteLine();

Console.Write("Entre com um valor para saque: "); 
pessoa.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.WriteLine();

Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(pessoa);