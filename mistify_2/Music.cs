public class Music
{
    public string NomeMusica { get; set;}
    public string Artista { get; set;}
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
            Console.WriteLine("\nDisponível no plano.");
        }
        else
        {
            Console.WriteLine("\nAdquira no Plano Magic+");
        }
    }
}