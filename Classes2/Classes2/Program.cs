using Classes2;
using System.Globalization;

Produto p = new Produto(); //Declarando e já instanciando

Console.WriteLine("Digite os dados do produto");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"Dados do produto: {p}");

Console.WriteLine();

Console.WriteLine("Deseja adicionar produtos ao estoque? Pressione 1 para SIM e 2 para NÃO.");
int opc = int.Parse(Console.ReadLine());

while (opc == 1)
{
    Console.Write("Digite a quantidade de produtos: ");
    int qte = int.Parse(Console.ReadLine());
    p.AdicionarProdutos(qte);

    Console.WriteLine();

    Console.WriteLine($"Dados atualizados: {p}");
    Console.WriteLine();

    Console.WriteLine("Deseja adicionar produtos ao estoque? Pressione 1 para SIM e 2 para NÃO.");
    opc = int.Parse(Console.ReadLine());

    Console.Clear();
}

Console.WriteLine($"Dados do produto: {p}");
Console.WriteLine();

Console.WriteLine("Deseja remover produtos ao estoque? Pressione 1 para SIM e 2 para NÃO.");
opc = int.Parse(Console.ReadLine());

while (opc != 2)
{
    Console.Write("Digite a quantidade de produtos: ");
    int qte = int.Parse(Console.ReadLine());
    p.RemoverProdutos(qte);

    Console.WriteLine();

    Console.WriteLine($"Dados atualizados: {p}");
    Console.WriteLine();

    Console.WriteLine("Deseja remover produtos ao estoque? Pressione 1 para SIM e 2 para NÃO.");
    opc = int.Parse(Console.ReadLine());
    
    Console.Clear();
}

Console.WriteLine($"Dados do produto: {p}");