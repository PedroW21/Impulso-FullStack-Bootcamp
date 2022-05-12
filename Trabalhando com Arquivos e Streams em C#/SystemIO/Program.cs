using static System.Console;

WriteLine("Digite o nome do arquivo:");

var nomeArquivo = ReadLine();

//Verificando se há caracteres especiais

foreach(var @char in Path.GetInvalidFileNameChars()) { //usando palavra reservada como variavel no C# (use @)
    nomeArquivo = nomeArquivo.Replace(@char, '-');
};


var path = Path.Combine(Environment.CurrentDirectory, $"{nomeArquivo}.txt");

CriarArquivo(path);

static void CriarArquivo(string path)
{
    try
    {
        // caso eu colocasse o using antes do "var streamWriter...", o metodo contem uma interface que força a descarga da memoria, não necessitando do flush no codigo
        var streamWriter = File.CreateText(path);

        streamWriter.WriteLine("Oi! Fui escrito por um programa :D! Linha 1");
        streamWriter.WriteLine("Oi! Fui escrito por um programa :X! Linha 2");
        streamWriter.WriteLine("Oi! Fui escrito por um programa :P! Linha 3");

        // O metodo não foi encerrado de maneira correta, precisando do metodo abaixo para que de fato escreva no .txt

        streamWriter.Flush(); // Realiza a descarga da memoria no arquivo (podendo ser por linha, por bloco de texto ou so no final da escrita do arquivo)

    }

    catch
    {
        WriteLine("O nome do arquivo está inválido!");
        WriteLine("Pressione ENTER para finalizar...");
        ReadLine();
    }

}

