using CsvHelper.Configuration;
public class LivroMap : ClassMap<Livro>
{
    public LivroMap()
    {
        Map(x=>x.Titulo).Name("titulo");
        Map(x=>x.Isbn).Name("isbn");
        Map(x=>x.Autor).Name("autor");
        Map(x=>x.Assunto).Name("assunto");
        Map(x=>x.Valor).Name("valor");

    }
}
