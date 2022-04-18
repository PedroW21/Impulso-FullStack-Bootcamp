using static System.Console;

public class Program
{

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

    static void TrocarNome(Pessoa p1, string nomeNovo) {
        p1.Nome = nomeNovo;
    }
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Pedro";
        p1.Idade = 19;
        p1.Documento = "1234";

        TrocarNome(p1, "Pierre");

        WriteLine($"O Novo nome é: {p1.Nome}");
    }
}