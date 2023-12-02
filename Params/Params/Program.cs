using Params;

int s1 = Calculadora.Soma(new int[] {2, 3}/*Forma compacta de instanciar vetores*/);
int s2 = Calculadora.Soma(2, 3, 4); //Quando tem um params não é necessario instanciar um vetor!

Console.WriteLine(s1);
Console.WriteLine(s2);