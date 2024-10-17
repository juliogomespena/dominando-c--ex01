namespace Alura_Filmes.Entidades;

internal class Ator
{
    public Ator(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        Filmes = new List<Filme>();
    }
    public string Nome { get; }
    public int Idade { get; }
    public List<Filme> Filmes { get; set; }
    public string informacoes => $"Nome: {Nome}, Idade: {Idade}\nFilmes: {ListarFilmes()}";
    public void AdicionarFilme(Filme filme)
    {
        Filmes.Add(filme);

        if(filme.Elenco.Contains(this) == false)
        {
            filme.AdicionarElenco(this);
        }
    }
    private string ListarFilmes()
    {
        string listaFilmes = "";
        int i = 1;
        foreach (var filme in Filmes)
        {
            if(i == Filmes.Count)
                listaFilmes += $"{filme.Titulo}";
            else
                listaFilmes += $"{filme.Titulo} / ";
            i++;
        }
        return listaFilmes;
    }
}
