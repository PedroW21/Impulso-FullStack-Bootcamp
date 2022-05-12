using static System.Console;

var path = @"~\Área de Trabalho\DIO\Impulso-FullStack-Bootcamp\Trabalhando c
om Arquivos e Streams em C#\Directory_And_DirectoryInfo\Terra";

LerDir(path);

WriteLine("Pressione ENTER para finalizar...");

ReadLine();

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

