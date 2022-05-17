public class Pessoa
{
    public string Nome { get; set; }

    public int Idade { get; set; }

    public void Mostrar()
    {
        Console.WriteLine($"Olá {Nome}!! Você tem {Idade} anos?");
    }
}
