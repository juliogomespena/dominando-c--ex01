namespace Alura_Filmes.Entidades;

internal class Filme
{
    public Filme(string titulo, int duracao)
    {
        Titulo = titulo;
        Duracao = duracao;
        Elenco = new List<Ator>();
    }
    public string Titulo { get; }
    public int Duracao { get; }
    public List<Ator> Elenco { get; set; }
    public string informacoes => $"Título: {Titulo}, Duração: {Duracao}\nElenco: {listarElenco()}";
    public void AdicionarElenco(Ator ator)
    {
        Elenco.Add(ator);
        if(ator.Filmes.Contains(this) == false)
        {
            ator.AdicionarFilme(this);
        }
    }
    private string listarElenco()
    {
        string listaElenco = "";
        int i = 1;
        foreach (var ator in Elenco)
        {
            if (i == Elenco.Count)
                listaElenco += $"{ator.Nome}";
            else
                listaElenco += $"{ator.Nome} / ";
            i++;
        }

        return listaElenco;
    }
}
