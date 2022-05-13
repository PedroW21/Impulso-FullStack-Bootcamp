using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;
using static System.Console;

// LerCsvDinamyc();

LerCsvComClasse();

WriteLine("Pressione ENTER para sair...");
ReadLine();

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




