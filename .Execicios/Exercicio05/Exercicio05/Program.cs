using System.Globalization;

Console.WriteLine("Digite o seu número de cadastro, número de horas trabalhadas e o válor da hora trabalhada (MESMA LINHA E SEPARADOS POR ESPAÇO):");
string[] funcionario = Console.ReadLine().Split(' ');

int numCadastro = int.Parse(funcionario[0]);
int horasTrabalhadas = int.Parse(funcionario[1]);
double valorHora = double.Parse(funcionario[2], CultureInfo.InvariantCulture);

double salario = horasTrabalhadas * valorHora;

Console.WriteLine($"Funcionario {numCadastro}, seu salário será: R${salario.ToString("F2", CultureInfo.InvariantCulture)}");