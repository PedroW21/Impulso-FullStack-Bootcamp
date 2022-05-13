using static System.Console;
using System.Text;

/* Parte 01 - Prática

var sb = new StringBuilder();

sb.AppendLine("Essa é a primeira linha desse texto");
sb.AppendLine("Chegou a 2a linha desse texto");
sb.AppendLine("E por ultimo mas não menos importante, a 3a e ultima linha");

using var sr = new StringReader(sb.ToString());

var buffer = new char[10];

var tamanho = buffer.Length;

do {
    WriteLine(sr.ReadLine());
} while (sr.Peek() >= 0); // consome o proximo caracter, e caso nao tenha retorna -1


/*

do
{
    buffer = new char[10]; // zera o buffer para (limpa)

    tamanho = sr.Read(buffer);
    WriteLine(string.Join("", buffer)); // se eu usasse o Write somente, ele mostraria normal e não quebraria a cada 10 char

} while (tamanho >= buffer.Length);

*/

string textReaderText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Sit amet cursus sit amet. Sed vulputate mi sit amet mauris commodo quis. Amet tellus cras adipiscing enim eu. Facilisi morbi tempus iaculis urna id volutpat lacus laoreet non. Faucibus purus in massa tempor nec feugiat. Urna id volutpat lacus laoreet non curabitur gravida arcu ac. At erat pellentesque adipiscing commodo elit at. Netus et malesuada fames ac turpis egestas sed. Massa ultricies mi quis hendrerit dolor. Ut tellus elementum sagittis vitae et leo duis. Ligula ullamcorper malesuada proin libero nunc consequat interdum. Varius duis at consectetur lorem. Facilisis magna etiam tempor orci eu lobortis elementum nibh\n " + "Vitae sapien pellentesque habitant morbi tristique. At risus viverra adipiscing at in tellus integer. Varius duis at consectetur lorem donec. Et netus et malesuada fames ac turpis egestas sed tempus. Mauris cursus mattis molestie a. Suspendisse potenti nullam ac tortor. Laoreet non curabitur gravida arcu ac tortor dignissim. Vitae sapien pellentesque habitant morbi tristique senectus et netus. Scelerisque felis imperdiet proin fermentum leo vel orci. Amet consectetur adipiscing elit duis tristique sollicitudin nibh. Ullamcorper dignissim cras tincidunt lobortis feugiat vivamus at. \n" + " Enim facilisis gravida neque convallis a cras semper. Congue eu consequat ac felis donec. Amet consectetur adipiscing elit duis tristique sollicitudin nibh. Lacus sed viverra tellus in hac. Tristique risus nec feugiat in fermentum posuere. Semper feugiat nibh sed pulvinar proin gravida. Et malesuada fames ac turpis egestas sed tempus urna. Non tellus orci ac auctor. Vestibulum morbi blandit cursus risus. Rhoncus est pellentesque elit ullamcorper dignissim cras tincidunt lobortis feugiat. Gravida cum sociis natoque penatibus. Massa tempor nec feugiat nisl pretium. Odio ut sem nulla pharetra diam sit amet. Varius vel pharetra vel turpis nunc eget lorem dolor. In hendrerit gravida rutrum quisque non tellus orci ac\n";

WriteLine($"Texto original:\n\n{textReaderText}");

string linha, paragrafo = null;

var sr = new StringReader(textReaderText);

while(true)
{
    linha = sr.ReadLine();

    if(linha != null)
    {
        paragrafo += linha + " ";
    }
    else
    {
        paragrafo += "\n";
        break;
    }
}

WriteLine($"Texto modificado:\n\n {paragrafo} \n\n");

int caracterLido;
char caracterConvertido;

var sw = new StringWriter();

sr = new StringReader(paragrafo);

while(true)
{
    caracterLido = sr.Read();
    if(caracterLido == -1) break;

    caracterConvertido = Convert.ToChar(caracterLido);

    if(caracterConvertido == '.') 
    {
        sw.Write("\n\n");
        sr.Read();
        sr.Read();
    } else {
        sw.Write(caracterConvertido);
    }

}

WriteLine($"Texto armazenado no StringWriter:\n\n {sw.ToString()}\n\n");


WriteLine("Pressione ENTER para finalizar...");
ReadLine();

