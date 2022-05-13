using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;
using static System.Console;

var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "Produtos.csv");

var fi = new FileInfo(path);

if(!fi.Exists) throw new FileNotFoundException($"O arquivo {path} não existe!!!");

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

WriteLine("Pressione ENTER para sair...");
ReadLine();
