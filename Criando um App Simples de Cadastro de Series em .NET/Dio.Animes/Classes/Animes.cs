public class Animes : EntidadeBase
{
    // Atributos
    private Genero Genero { get; set; }

    private string Titulo { get; set; }

    private string Descricao { get; set; }

    private int Ano { get; set; }

    private bool Excluido { get; set; }

    // Metodos

    public Animes(int id, Genero genero, string titulo, string descricao, int ano)
    {
        this.Id = id;
        this.Genero = genero;
        this.Titulo = titulo;
        this.Descricao = descricao;
        this.Ano = ano;
        this.Excluido = false;
    }

    public override string ToString()
    {
        // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view-netcore-3.1

        string retorno = "";

        retorno += "Gênero: " + this.Genero + Environment.NewLine;
        retorno += "Titulo: " + this.Titulo + Environment.NewLine;
        retorno += "Ano: " + this.Ano + Environment.NewLine;
        retorno += "Descricao: " + this.Descricao + Environment.NewLine;
        retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
        retorno += "Excluido: " + this.Excluido;


        return retorno;
    }

    public string RetornaTitulo()
    {
        return this.Titulo;
    }

    public int RetornaId()
    {
        return this.Id;
    }

    public void Excluir()
    {
        this.Excluido = true;
    }
}
