var path = Path.Combine(Environment.CurrentDirectory, "text.txt");


// caso eu colocasse o using antes do "var streamWriter...", o metodo contem uma interface que força a descarga da memoria, não necessitando do flush no codigo
var streamWriter = File.CreateText(path);

streamWriter.WriteLine("Oi! Fui escrito por um programa :D! Linha 1");
streamWriter.WriteLine("Oi! Fui escrito por um programa :X! Linha 2");
streamWriter.WriteLine("Oi! Fui escrito por um programa :P! Linha 3");

// O metodo não foi encerrado de maneira correta, precisando do metodo abaixo para que de fato escreva no .txt

streamWriter.Flush(); // Realiza a descarga da memoria no arquivo (podendo ser por linha, por bloco de texto ou so no final da escrita do arquivo)