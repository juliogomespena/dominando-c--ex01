using Alura_Filmes.Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        var filme01 = new Filme("Star Wars - Episódio I", 135);
        var filme02 = new Filme("Star Wars - Episódio II", 135);
        var filme03 = new Filme("Star Wars - Episódio III", 135);
        var filme04 = new Filme("Star Wars - Episódio IV", 135);
        var filme05 = new Filme("Star Wars - Episódio V", 135);
        var filme06 = new Filme("Star Wars - Episódio VI", 135);

        var ator01 = new Ator("Hayden Christensen", 40);
        var ator02 = new Ator("Ewan McGregor", 50);
        var ator03 = new Ator("Samuel Jackson", 70);
        var ator04 = new Ator("Natalie Portman", 40);
        var ator05 = new Ator("Mark Hamill", 70);
        var ator06 = new Ator("Harrison Ford", 80);
        var ator07 = new Ator("Carrie Fisher", 70);

        filme01.AdicionarElenco(ator01);
        filme01.AdicionarElenco(ator05);
        filme01.AdicionarElenco(ator07);
        filme02.AdicionarElenco(ator02);
        filme02.AdicionarElenco(ator04);
        filme02.AdicionarElenco(ator05);
        filme03.AdicionarElenco(ator03);
        filme03.AdicionarElenco(ator06);
        filme03.AdicionarElenco(ator04);
        filme04.AdicionarElenco(ator04);
        filme04.AdicionarElenco(ator05);
        filme04.AdicionarElenco(ator06);
        filme04.AdicionarElenco(ator07);
        filme05.AdicionarElenco(ator05);
        filme05.AdicionarElenco(ator03);
        filme05.AdicionarElenco(ator01);
        filme06.AdicionarElenco(ator06);
        filme06.AdicionarElenco(ator07);

        Console.WriteLine(filme01.informacoes.ToString());
        Console.WriteLine();
        Console.WriteLine(filme02.informacoes);
        Console.WriteLine();
        Console.WriteLine(filme03.informacoes);
        Console.WriteLine();
        Console.WriteLine(filme04.informacoes);
        Console.WriteLine();
        Console.WriteLine(filme05.informacoes);
        Console.WriteLine();
        Console.WriteLine(filme06.informacoes);
        Console.WriteLine();
        Console.WriteLine(ator01.informacoes);


    }
}
  