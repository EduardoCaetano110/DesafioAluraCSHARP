class Episodio
{
    private List<string> convidados = new();
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }
    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"{Ordem}. {Titulo} - {string.Join(", ", convidados)} ({Duracao}min)";


    public void AddConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}