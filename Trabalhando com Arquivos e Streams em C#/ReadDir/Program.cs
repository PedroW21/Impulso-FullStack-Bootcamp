using static System.Console;

var path = @"~\Área de Trabalho\DIO\Impulso-FullStack-Bootcamp\Trabalhando c
om Arquivos e Streams em C#\Directory_And_DirectoryInfo\Terra";

//LerDir(path);
LerArquivos(path);
WriteLine("Pressione ENTER para finalizar...");
ReadLine();

static void LerArquivos(string path)
{
    var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

    foreach (var arquivo in arquivos)
    {
        var fileInfo = new FileInfo(path);

        WriteLine($"[Nome]: {fileInfo.Name}");
        WriteLine($"[Tamanho]: {fileInfo.Length}");
        WriteLine($"[Ultimo acesso]: {fileInfo.LastAccessTime}");
        WriteLine($"[Pasta]: {fileInfo.DirectoryName}");

        WriteLine("--------------------&--------------------");


    }
}

static void LerDir(string path)
{
    if (Directory.Exists(path))
    {
        var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories); // todos os diretorios, posso selecionar so os que começam com p assim: p*
        foreach (var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);

            WriteLine($"[Nome]: {dirInfo.Name}");
            WriteLine($"[Raiz]: {dirInfo.Root}");

            if (dirInfo.Parent != null)
                WriteLine($"[Pai]: {dirInfo.Parent.Name}");

            WriteLine("--------------------&--------------------");
        }
    }

    else

    {
        WriteLine($"{path} não existe!!");
    }

}

