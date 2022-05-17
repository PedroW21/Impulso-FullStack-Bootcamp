using static System.Console;

Data data = new Data();

data.SetMes(20);
data.MostraMesValido();

static void ExemploConstrutores()
{
    Aluno aluno = new Aluno("Santo", "Andre", "Geografia");
    Pessoa p1 = new Pessoa("Pierre", "Danté");

    p1.Mostrar();

    //Log log = Log.GetInstance();

    //log.PropriedadeLog = "Teste Instancia";

    //Log log2 = Log.GetInstance();

    //WriteLine(log2.PropriedadeLog);
}