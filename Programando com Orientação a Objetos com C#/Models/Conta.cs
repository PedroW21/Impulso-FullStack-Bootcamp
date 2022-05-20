public abstract class Conta
{
    protected double saldo;

    public abstract void Creditar(double valor); // não permite implementações

    public void ExibirSaldo()
    {
        Console.WriteLine($"Seu saldo é {saldo}");
    }
}