public class Pessoa
{
    private string nome;
    private string sobrenome;

    // public Pessoa()
    // {
    //     nome = string.Empty;
    //     sobrenome = string.Empty;
    // }

    public Pessoa(string nome, string sobrenome)
    {
        this.nome = nome;
        this.sobrenome = sobrenome;
        Console.WriteLine("Construtor da classe pessoa");
    }

    public void Mostrar()
    {
        Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
    }
}
