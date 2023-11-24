//Conversão implicita ocorre quando um tipo de dado consegue ser adicionado a outro, exemplo
//o float pode receber 4bits, enquanto o double pode receber 8bits, então cabe um float dentro de um double;
float n1 = 4.5f;
double n2 = n1;

Console.WriteLine(n2);

//Casting é quando queremos adicionar um dado dentro de uma variavel que "não suporta".
//Exemplo como o double é 8bits, os dados dele não são suportados no float que é apenas 4bits. Então devemos 'forçar' a conversão colocando na frente.
double n3 = 9.51;
float n4 = (float)n3; // Aqui basicamente estamos mandando o compilador jogar o valor do double para o float e que nos responsabilizamos caso haja perda de informação

Console.WriteLine(n4);

double n5 = 5.5;
int n6 = (int)n5;// Aqui basicamente estamos mandando o compilador jogar o valor do double para o int e que nos responsabilizamos caso haja perda de informação

Console.WriteLine(n6);

int a = 5;
int b = 2;

double res = (double) a / b; //Se não fizer o casting, ele irá "jogar fora" as casas decimais por ser divisão de dois inteiros.

Console.WriteLine(res);