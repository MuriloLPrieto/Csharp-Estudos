using Exercicio23_Classes;
using System.Globalization;

Aluno aluno = new Aluno();

Console.WriteLine("Digite seu nome:");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Digite as três notas do aluno: ");
aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

aluno.Verificador();