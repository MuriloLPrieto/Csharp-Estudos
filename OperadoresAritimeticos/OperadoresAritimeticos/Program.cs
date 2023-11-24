class Program
{
    static void Main(string[] args)
    {
        int n1 = 3 + 4 * 2;
        Console.WriteLine(n1);

        int n2 = (3 + 4) * 2;
        Console.WriteLine(n2);

        int n3 = 17 % 3; //resto da divisão ou mod
        Console.WriteLine(n3);

        float n4 =  10.0f / 8; //Se deixar dois numeros inteiros o resultado será um numero inteiro tmb
        Console.WriteLine(n4);

        double a = 1.0, b = -3.0, c = -4.0;
        double delta = Math.Pow(b, 2.0) - 4 * a * c; //Pow vem de potenciação

        double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); //Sqrt é raiz quadrada
        double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

        Console.WriteLine(delta);
        Console.WriteLine(x1);
        Console.WriteLine(x2);
    }
}