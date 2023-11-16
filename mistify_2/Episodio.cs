class Episodio
{
    private List<string> convidados = new();
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Duracao = duracao;
        Titulo = titulo;
    }
    
    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao}) min - {string.Join(", ", convidados)}";
    public string Titulo { get; }

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }
}