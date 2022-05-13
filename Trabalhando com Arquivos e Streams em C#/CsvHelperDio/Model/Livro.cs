using CsvHelper.Configuration.Attributes;

public class Livro
{
    // caso o csv não tivesse cabeçalho, poderiamos utilizar o [Index(x)]
    public string Titulo { get; set; }

    public string Isbn { get; set; }

    public string Autor { get; set; }

    public string Assunto { get; set; }

    public string Valor { get; set; }

    //caso tivesse uma data, seria o seguinte [Name("dd/MM/yyyy")]
}
