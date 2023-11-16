class Podcast
{
    private List<Episodio> episodios = new();
    public Podcast(string nome, string host)
    {
        Host = host;
        Nome = nome;
    }
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;
    
    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Exibindo o Podcast {Nome} apresentado por {Host}\n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine($"Este Podcast possui {TotalEpisodios} episodios.");
    }
}