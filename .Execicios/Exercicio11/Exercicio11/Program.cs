Console.WriteLine("Digite o horario que o jogo começou:");
int horaIni = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o horario que o jogo terminou:");
int horaFin = int.Parse(Console.ReadLine());

int total = 0;


if (horaIni < horaFin)
{
    total = horaIni - horaFin;
}
else
{
    total = 24 - horaIni + horaFin;
}

Console.WriteLine($"{total}");