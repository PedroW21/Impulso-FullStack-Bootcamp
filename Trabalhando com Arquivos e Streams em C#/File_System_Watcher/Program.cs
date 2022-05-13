using static System.Console;

var path = @"/home/pedro/Documentos/Terra";

using var fsw = new FileSystemWatcher(path);

fsw.Created += OnCreated;
fsw.Deleted += OnDeleted;
fsw.Renamed += OnRenamed;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

WriteLine($"Monitorando eventos na pasta {path}");

WriteLine("Pressione ENTER para finalizar...");
ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    WriteLine($"Foi criado o arquivo {e.Name}");
}


void OnDeleted(object sender, FileSystemEventArgs e)
{
    WriteLine($"Foi excluido o arquivo {e.Name}");
}


void OnRenamed(object sender, RenamedEventArgs e)
{
    WriteLine($"O arquivo {e.OldName} foi renomeado para {e.Name}");
}

