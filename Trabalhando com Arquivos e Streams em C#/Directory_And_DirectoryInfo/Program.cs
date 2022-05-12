using static System.Console;

var path = Path.Combine(Environment.CurrentDirectory, "Terra");

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








