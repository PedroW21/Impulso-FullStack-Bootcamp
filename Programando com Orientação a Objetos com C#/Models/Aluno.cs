public class Aluno : Pessoa
{
    public double Nota { get; set; }

    public override void Mostrar()
    {
        Console.WriteLine($"Olá {Nome}!! Você é um aluno nota {Nota}!!!\nParabéns!!!");
    }
}
