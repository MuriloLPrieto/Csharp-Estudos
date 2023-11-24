//Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
//um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
//4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
//que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
//mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível

Console.WriteLine("Digite 1 para Gasolina, 2 para Diesel, 3 para Alcool e 4 para Finalizar:");
int opc = int.Parse(Console.ReadLine());

int gas = 0, diesel = 0, alcool = 0;

if (opc > 4){
    Console.WriteLine($"Opcao invalida digite novamente:");
    opc = int.Parse(Console.ReadLine());
}


while (opc != 4)
{
    switch (opc)
    {
        case 1:
            gas++;
            Console.WriteLine($"Gasolina: {gas}");
            break;
        case 2:
            diesel++;
            Console.WriteLine($"Diesel: {diesel}");
            break;
        case 3: 
            alcool++;
            Console.WriteLine($"Alcool: {alcool}");
            break;
    }
    Console.WriteLine("Vote novamente:");
    opc = int.Parse(Console.ReadLine());
}
Console.WriteLine("Obrigado Pela preferencia");
