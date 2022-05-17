public class Pessoa
{
    public string Nome { get; set; }

    public int Idade { get; set; }

    public virtual void Mostrar()
    {
        Console.WriteLine($"Olá {Nome}!! Você tem {Idade} anos?");
    }
}
