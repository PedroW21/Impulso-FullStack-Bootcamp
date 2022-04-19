using static System.Console;

public class Program
{
    static void Demo5()
    {
        var pares = new int[] { 0, 2, 4, 6, 8 }; // poderia ser int[] pares = new int[x,x,x,x]

        MudarParaImpar(pares);

        WriteLine($"Os impares {string.Join(",", pares)}");
    }
    static void Demo4()
    {
        string nome = "Pedro";

        TrocarNome(nome, "Pierre");

        WriteLine($"O nome novo é: {nome}");
    }
    static void Demo3()
    {
        StructPessoa p1 = new StructPessoa()
        {
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
    static void Demo2()
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
    static void Demo1()
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

    static void TrocarNome(StructPessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }

    static void TrocarNome(string nome, string nomeNovo)
    {
        nome = nomeNovo;
    }

    static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
        }
    }

    public static void Main()
    {

    }
}