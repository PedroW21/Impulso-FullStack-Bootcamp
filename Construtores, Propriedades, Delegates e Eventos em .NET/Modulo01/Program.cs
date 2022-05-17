using static System.Console;

class Program
{
    public delegate void Operacao(int x, int y); // delegate me obrigou a colocar toda a estrutura padrao novamente

    static void Main(string[] args)
    {

        static void ExemploEventos()
        {
            Matematica m = new Matematica(10, 20);

            m.Somar();
        }

        static void ExemploDelegates()
        {
            // Operacao op = Operacao(Calculadora.Somar); - outra maneira 
            Operacao op = new Operacao(Calculadora.Somar);
            op += Calculadora.Subtrair; // Muti Cast Delegate - pacote dois em um (resumindp)

            // op(10,10) - outro jeito
            op.Invoke(10, 12);
        }

        static void ExemploModificadores()
        {
            //readonly esta na classe Pessoa
            const double pi = 3.14;
            WriteLine(pi);
            // pi = 0; daria erro por ser const
            // const double pi; daria erro pois precisa ter valor em sua inicialização
        }

        static void ExemploGetAndSet()
        {
            Data data = new Data();

            // Get e set feito por nos
            //data.SetMes(20);
            //data.MostraMesValido();

            // Get and Set - outro meio

            data.Mes = 7;
            data.MostraMesValido();

        }

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

    }
}
