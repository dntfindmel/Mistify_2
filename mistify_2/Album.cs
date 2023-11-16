class Album
{
    private List<Music> musicas = new List<Music>();

    public Album(string nome)
    {
        Nome = nome;
    }
    
    public string Nome { get; }
    public int duracaoTotal => musicas.Sum(mu => mu.Duracao);

    public void AdicionarMusica(Music musica)
    {
        musicas.Add(musica);
    }

    public void ExbirMusicasAlbum()
    {
        Console.WriteLine($"\nOuça o álbum inteiro em {duracaoTotal} segundos");
        Console.WriteLine($"Exibindo músicas do álbum {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.NomeMusica}");
        }
    }
}