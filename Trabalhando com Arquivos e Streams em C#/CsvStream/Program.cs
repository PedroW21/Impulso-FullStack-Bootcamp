using static System.Console;

var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "usuarios-exportacao.csv");

if (File.Exists(path))
{
    using var sr = new StreamReader(path);

    var cabecalho = sr.ReadLine()?.Split(","); // ? = se for nulo, ignore a proxima instrução

    while (true)
    {
        var registro = sr.ReadLine()?.Split(",");

        if (registro == null) break;

        if(cabecalho.Length != registro.Length) {
            WriteLine($"Arquivo fora do padrão!!");
            break;
        }

        for (int i = 0; i < registro.Length; i++)
        {
            WriteLine($"{cabecalho?[i]}:{registro[i]}");
        }

        WriteLine("----------&----------");
    }

    WriteLine("\n\nPressione ENTER para sair...");
    ReadLine();

} else {
    WriteLine($"{path} não existe!! \n\nPressione enter para sair...");
    ReadLine();
}


