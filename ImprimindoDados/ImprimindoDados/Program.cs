using System.Globalization;

int age = 32;
string name = "Maria";
double money = 10.32434;

//Place Holder
Console.WriteLine("{0} tem {1} anos e tem saldo igual a: {2:F2} Reais.", name, age, money);

//Interpolação -> Disponiveis nas versões 6.0 em diante do C#
Console.WriteLine($"{name} tem {age} anos e tem saldo igual a: {money:F2} Reais.");

//Concatenação de Strings
Console.WriteLine(name + " tem " + age + " anos e tem saldo igual a: " + money.ToString("F2") + " Reais.");
/*Lembrando que para alterar a Virgula por Ponto na casa decimal
Apenas funciona dentro do metodo .ToString("", CultureInfo.IvariantCulture) 
utilizando o usign System.Globalization; 
    Tentar fazer o CultureInfo nas chaves {age:F2.CultureInfo} não da certo!
*/