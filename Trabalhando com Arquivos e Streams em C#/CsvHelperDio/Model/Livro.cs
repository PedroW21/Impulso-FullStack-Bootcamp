using CsvHelper.Configuration.Attributes;

public class Livro
{
    [Name("titulo")]
    public string Titulo { get; set; }

    [Name("isbn")]
    public string Isbn { get; set; }

    [Name("autor")]
    public string Autor { get; set; }

    [Name("assunto")]
    public string Assunto { get; set; }

    [Name("valor")]
    public string Valor { get; set; }

    //caso tivesse uma data, seria o seguinte [Name("dd/MM/yyyy")]
}
