public class Corrente : Conta
{
    public override void Creditar(double valor)
    {
        base.saldo = valor; // base se refere (entende) que esse atributo vem da classe pai
    }
}



