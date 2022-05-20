public class Calculadora : ICalculadora //segurei ctrl + "." para implementar a interface
{   
    // Não da erro pois quando o metodo ja tem uma implementação na interface, não somos obrigados a implementar aqui.
    // public int Dividir(int num1, int num2)
    // {
    //     return num1 / num2;
    // }

    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    } 
    public int Somar(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

    public int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    }
}
