public class Pessoa
{
    private readonly string nome = "Pietro";
    private readonly string sobrenome;

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
    { // Aqui por exemplo não seria possível mudar o campo readonly, somente na sua inicialização ou por meio de construtor
        Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
    }
}
