class Music
{
    public Music(Banda artista, string nome)
    {
        Artista = artista.ToString();
        NomeMusica = nome;
    }
    public string NomeMusica { get; }
    public string Artista { get; }
    public int Duracao { get; set;}
    public bool Disponivel { get; set;}

    public string Descricao => $"A música {NomeMusica} pertence ao artista {Artista}";
    public void FichaTecnica()
    {
        Console.WriteLine($"\nNome: {NomeMusica}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira no Plano Magic+");
        }
    }
}