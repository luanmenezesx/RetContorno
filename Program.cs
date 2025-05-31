Console.Clear();

Console.WriteLine("Tamanho do retângulo: ");

Console.Write("Digite um valor para a altura: ");
int altura = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite um valor para a largura: ");
int largura = Convert.ToInt32(Console.ReadLine());

if (altura > 10 || largura > 10 || altura < 1 || largura < 1)
{
    Console.Write("Valores inválidos, digite número entre 1 e 10!");
}

Console.WriteLine();


for (int linhaAtual = 1; linhaAtual <= altura; linhaAtual++)
{
    string linha = "";

    for (int colunaAtual = 1; colunaAtual <= largura; colunaAtual++)
    {
        bool borda = linhaAtual == 1 || linhaAtual == altura || colunaAtual == 1 || colunaAtual == largura;

        if (borda)
        {
            linha += "*";
        }
        else
        {
            linha += " ";
        }
    }
         Console.WriteLine(linha);
}