using static System.Console;

CriarDiretoriosTerra();
CriarArquivo();

var origem = Path.Combine(Environment.CurrentDirectory, "Brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory, "Terra", "América do Sul", "Argentina", "Argentina.txt");

MoverArquivo(origem, destino);
CopiarArquivo(origem, destino);

static void CopiarArquivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        WriteLine("Arquivo de origem não existe!");
        return;
    }

    if (File.Exists(pathDestino))
    {
        WriteLine("Arquivo já existe no destino!");
        return;
    }
    
    File.Copy(pathOrigem, pathDestino);
}


static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        WriteLine("Arquivo de origem não existe!");
        return;
    }

    if (File.Exists(pathDestino))
    {
        WriteLine("Arquivo já existe no destino!");
        return;
    }

    File.Move(pathOrigem, pathDestino);
}


static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Brasil.txt");

    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("População: 250 milhões");
        sw.WriteLine("IDH: 0.725");
        sw.WriteLine("Fonte: Minha mente");
    }


}

static void CriarDiretoriosTerra()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Terra");

    if (!Directory.Exists(path))
    {
        var dirGlobo = Directory.CreateDirectory(path);

        var dirAmNorte = dirGlobo.CreateSubdirectory("América do Norte");
        var dirAmCentral = dirGlobo.CreateSubdirectory("América Central");
        var dirAmSul = dirGlobo.CreateSubdirectory("América do Sul");

        dirAmNorte.CreateSubdirectory("Canada");
        dirAmNorte.CreateSubdirectory("USA");
        dirAmNorte.CreateSubdirectory("México");

        dirAmCentral.CreateSubdirectory("Costa Rica");
        dirAmCentral.CreateSubdirectory("Panama");
        dirAmCentral.CreateSubdirectory("El Salvador");
        dirAmCentral.CreateSubdirectory("Honduras");

        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Chile");
        dirAmSul.CreateSubdirectory("Colombia");
        dirAmSul.CreateSubdirectory("Argentina");
        dirAmSul.CreateSubdirectory("Uruguai");
    }



}











