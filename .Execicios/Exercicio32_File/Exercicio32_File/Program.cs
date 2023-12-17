using System.IO;
using System.Globalization;
using Exercicio32_File.Entidades;

Console.WriteLine("Digite o caminho raiz: ");
string diretorioRaiz = Console.ReadLine();

try
{
    string[] linhas = File.ReadAllLines(diretorioRaiz);

    string pegandoRaiz = Path.GetDirectoryName(diretorioRaiz);
    string novaPasta = pegandoRaiz + @"\saida";
    string arquivoTexto = novaPasta + @"\sumario.csv";

    Directory.CreateDirectory(novaPasta);

    using (StreamWriter sw = File.AppendText(arquivoTexto))
    {
        foreach (string linha in linhas)
        {
            string[] conteudo = linha.Split(',');

            string nome = conteudo[0];
            double valor = double.Parse(conteudo[1], CultureInfo.InvariantCulture);
            int quantia = int.Parse(conteudo[2]);

            Produto prod = new Produto(nome, valor, quantia);
            sw.WriteLine(prod.Nome + ", R$" + prod.ValorTotal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }

}
catch (IOException e)
{
    Console.WriteLine($"Erro: {e.Message}");
}