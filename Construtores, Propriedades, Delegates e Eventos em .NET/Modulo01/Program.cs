using static System.Console;

Data data = new Data();

// Get e set feito por nos
//data.SetMes(20);
//data.MostraMesValido();

// Get and Set - outro meio

data.Mes = 7;
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