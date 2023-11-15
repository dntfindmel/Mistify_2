class Album
{
    private List<Music> musicas = new List<Music>();
    public string Nome { get; set; }
    public int duracaoTotal => musicas.Sum(mu => mu.Duracao);

    public void AdicionarMusica(Music musica)
    {
        musicas.Add(musica);
    }

    public void ExbirMusicasAlbum()
    {
        Console.WriteLine($"Exibindo músicas do álbum {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.NomeMusica}");
        }
    }
}