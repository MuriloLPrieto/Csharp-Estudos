using System;
using System.Globalization;

namespace TiposVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Variaveis numericas inteiras");
            sbyte x = 100; //Pode utilizar SByte tmb, porêm precisa carregar o pacote System
            byte n1 = 255;

            n1++;
            /*Quando um valor estrapola o limite do tipo
            da variavel, a variavel recebe o limite oposto
            do tipo da variavel, no caso do byte que o limite
            é 255, será impresso 0, que é o limite oposto
            */

            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; //O 'L' é para indicar que é um long
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Valores Minimos e Maximos dos tipos de dados");
            int x1 = int.MinValue;
            int x2 = int.MaxValue;
            sbyte x3 = sbyte.MinValue;
            decimal x4 = decimal.MaxValue;
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Variaveis com ponto flutuante");
            float n5 = 4.5f; //o 'f' é para indicar pro c# que o valor é float ao inves de double
            double n6 = 4.5;
            double n7 = 4.567686756;
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7.ToString("F3")); //O 'F3' serve para imprimir apenas 3 casas decimais 
            Console.WriteLine(n7.ToString("F4", CultureInfo.InvariantCulture)); //O InvariantCulture vai mudar a ',' por '.'


            Console.WriteLine("----------------------------------");
            Console.WriteLine("Variaveis Booleanas");
            bool complete = false;
            Console.WriteLine(complete);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Variaveis de caracteres Unicos!");
            char genero = 'F';
            char letra = '\u0041'; //Definindo com caracter unicode, é so adicionar a '\u' e depois o codigo unicode 
            Console.WriteLine(genero);
            Console.WriteLine(letra);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Variavel de cadeia de caracteres");
            string nome = "Murilo Prieto";
            Console.WriteLine(nome);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Variaveis do tipo object");
            object obj1 = "Alex Cagado";
            object obj2 = 9.8f;
            Console.WriteLine("O tipo object é um tipo generico, logo aceita qualquer tipo de dado"); ;
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
}