using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;
using static System.Console;

// LerCsvDinamyc();

//LerCsvComClasse();

//LerCsvComOutroDelimitador();

EscreverCsv();

WriteLine("Pressione ENTER para sair...");
ReadLine();

static void EscreverCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Saida");

    var di = new DirectoryInfo(path);

    if (!di.Exists) di.Create();

    path = Path.Combine(path, "users.csv");

    var pessoas = new List<Pessoa>(){
        new Pessoa() {
            Nome = "Pedro",
            Email = "pdo@pdo.com",
            Telefone = 123456

        },
        new Pessoa() {
            Nome = "Joao",
            Email = "jao@jao.com",
            Telefone = 654321

        },new Pessoa() {
            Nome = "Victor",
            Email = "vcr@vcr",
            Telefone = 341265

        }
    };

    using var sw = new StreamWriter(path);
    using var csvWriter = new CsvWriter(sw, CultureInfo.InvariantCulture);
    csvWriter.WriteRecords(pessoas);
}

static void LerCsvComOutroDelimitador()
{

    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "atelie-catalogo-produtos.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists) throw new FileNotFoundException($"O arquivo {path} não existe!!!");

    using var sr = new StreamReader(fi.FullName);

    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";"
    };

    using var csvReader = new CsvReader(sr, csvConfig);
    csvReader.Context.RegisterClassMap<LivroMap>();
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




