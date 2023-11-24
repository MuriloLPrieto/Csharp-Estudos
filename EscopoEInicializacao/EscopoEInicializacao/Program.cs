namespace EscopoEInicializacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());

            if (preco > 100.0)
            {
                double desconto = preco * 0.1; 
                /* O if é um escopo a parte do programa principal, então variaveis iniciadas dentro dele não
                poderão ser utilizadas fora dele. Já a variavel preco foi inicializada dentro do escopo global do programa, isso permite que
                ela possa ser utilizada em qualquer metodo que tenha sido colocado dentro do escopo global, como o if no nosso exemplo.
                */
            }

            Console.WriteLine(desconto);
        }
    }
}
