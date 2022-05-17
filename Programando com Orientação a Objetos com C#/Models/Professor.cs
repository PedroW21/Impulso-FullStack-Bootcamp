public class Professor : Pessoa
{
    public double Salario { get; set; }

     public override void Mostrar()
    {
        Console.WriteLine($"Olá {Nome}!! Você teve um aumento de {Salario}!!!\nParabéns!!!");
    }

}
