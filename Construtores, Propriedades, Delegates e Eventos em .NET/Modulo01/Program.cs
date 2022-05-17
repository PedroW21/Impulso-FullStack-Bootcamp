using static System.Console;

Pessoa p2 = new Pessoa();
Pessoa p1 = new Pessoa("Pierre", "Danté");

p1.Mostrar();
p2.Mostrar();

Log log = Log.GetInstance();

log.PropriedadeLog = "Teste Instancia";

Log log2 = Log.GetInstance();

WriteLine(log2.PropriedadeLog);
