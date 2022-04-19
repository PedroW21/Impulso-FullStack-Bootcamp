using static System.Console;

public class Program
{
    static void demon2()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Pedro";
        p1.Idade = 19;
        p1.Documento = "1234";

        Pessoa p2 = p1.Clone();

        TrocarNome(p1, "Pierre");

        // o arroba aqui faz com que apareca essa formatação no console
        WriteLine($@"
        O nome de p1 é: {p1.Nome}
        O nome de p2 é: {p2.Nome}
        ");
    }
    static void demon1()
    {
        int a = 2;

        a = Adicionar20(a);

        WriteLine($"O valor atual da variável é: {a}");
    }
    static int Adicionar20(int x)
    {
        return x + 20;
    }

    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
    
    static void TrocarNome(StructPessoa p1, string nomeNovo) {
        p1.Nome = nomeNovo;
    }
    
    public static void Main()
    {
        StructPessoa p1 = new StructPessoa() {
            Documento = "1234",
            Idade = 30,
            Nome = "Pedro"
        };

        var p2 = p1;

        TrocarNome(p1, "Pierre");

        WriteLine($@"
        O nome de p1 é {p1.Nome}
        O nome de p2 é {p2.Nome}
        ");

    }
}