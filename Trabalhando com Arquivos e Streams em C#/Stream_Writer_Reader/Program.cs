using static System.Console;
using System.Text;

var sb = new StringBuilder();

sb.AppendLine("Essa é a primeira linha desse texto");
sb.AppendLine("Chegou a 2a linha desse texto");
sb.AppendLine("E por ultimo mas não menos importante, a 3a e ultima linha");

using var sr = new StringReader(sb.ToString());

var buffer = new char[10];

var tamanho = buffer.Length;

do
{
    buffer = new char[10]; // zera o buffer para (limpa)

    tamanho = sr.Read(buffer);
    WriteLine(string.Join("", buffer)); // se eu usasse o Write somente, ele mostraria normal e não quebraria a cada 10 char

} while (tamanho >= buffer.Length);

WriteLine("Pressione ENTER para finalizar...");
ReadLine();

