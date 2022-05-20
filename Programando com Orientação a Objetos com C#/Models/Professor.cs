public class Professor : Pessoa // caso eu colocasse aqui o sealed, essa classe não poderia ter classes filhas
{
    public double Salario { get; set; }

     public override void Mostrar() // caso eu coloque sealed aqui, este metodo não poderia ser sobrescrito (derivado), e aqui sera seu fim
    {
        Console.WriteLine($"Olá {Nome}!! Você teve um aumento de {Salario}!!!\nParabéns!!!");
    }

}
