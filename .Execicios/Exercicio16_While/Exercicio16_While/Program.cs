Console.WriteLine("Digite sua senha: ");
int senha = int.Parse(Console.ReadLine());

while (senha != 2002)
{
    Console.WriteLine("Senha incorreta, tente novamente:");
    senha = int.Parse(Console.ReadLine());
}
Console.WriteLine("Acesso permitido");