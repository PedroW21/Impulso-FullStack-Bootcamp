using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;
using static System.Console;

// LerCsvDinamyc();

//LerCsvComClasse();

LerCsvComOutroDelimitador();

WriteLine("Pressione ENTER para sair...");
ReadLine();

static void LerCsvComOutroDelimitador() {

    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "atelie-catalogo-produtos.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists) throw new FileNotFoundException($"O arquivo {path} não existe!!!"); 

    using var sr = new StreamReader(fi.FullName);

    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture) 
    {
        Delimiter = ";"
    };

    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Livro>();

    foreach (var registro in registros)
    {
        WriteLine($"titulo: {registro.Titulo}");
        WriteLine($"isbn: {registro.Isbn}");
        WriteLine($"autor: {registro.Autor}");
        WriteLine($"assunto: {registro.Assunto}");
        WriteLine($"valor: {registro.Valor}");
        WriteLine("---------&---------\n");
    } 
}

static void LerCsvComClasse()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "novos-usuarios.csv");
    var fi = new FileInfo(path);
    if (!fi.Exists) throw new FileNotFoundException($"O arquivo {path} não existe!!!");

    using var sr = new StreamReader(fi.FullName);

    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Usuario>();

    foreach (var registro in registros)
    {
        WriteLine($"nome: {registro.Nome}");
        WriteLine($"email: {registro.Email}");
        WriteLine($"telefone: {registro.Telefone}");
        WriteLine("---------&---------\n");
    }
}


static void lerCsvDinamyc()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "Produtos.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists) throw new FileNotFoundException($"O arquivo {path} não existe!!!");

    using var sr = new StreamReader(fi.FullName);

    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<dynamic>();

    foreach (var registro in registros)
    {
        WriteLine($"nome: {registro.nome}");
        WriteLine($"marca: {registro.marca}");
        WriteLine($"preço: {registro.preco}");
        WriteLine("---------&---------\n");
    }
}




