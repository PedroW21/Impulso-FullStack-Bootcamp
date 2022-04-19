using static System.Console;

class TrabalhandoComRef
{
    static void Demo01()
    {
        int a = 5;
        Adicionar20(ref a);

        WriteLine($"O valor de a é: {a}!");
    }
    static void Adicionar20(ref int a)
    {
        a += 20;
    }
    
    static void AlterarNome(string[] nomes, string nome, string novoNome)
    {
        for(int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == nome) 
            {
                nomes[i] = novoNome;
            }
        }
    }
    
    static void Main()
    {
        var nomes = new string[]{"Pedro","Victor","Ana","Anny","Jao","Samuel"};
        WriteLine($@"A lista de nomes atuais é:
        {string.Join(", \n", nomes)}
        ");


        WriteLine("Digite o nome a ser substituido: ");
        var nome =  ReadLine();
        WriteLine("Digite o nome novo: ");
        var nomeNovo = ReadLine();

        AlterarNome(nomes, nome, nomeNovo);

        WriteLine($@"A lista de nomes alterada é:
        {string.Join(", \n", nomes)}
        ");

    }
}