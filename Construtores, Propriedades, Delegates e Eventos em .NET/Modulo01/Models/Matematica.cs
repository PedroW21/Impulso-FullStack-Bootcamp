public class Matematica
{
    public int X { get; set; }
    public int Y { get; set; }

    public Matematica(int x, int y)
    {
        X = x;
        Y = y;

        Calculadora.EventoCalculadora += EventHanlder; // "Inscreve" de fato no evento
    }

    public void Somar()
    {
        Calculadora.Somar(X,Y);
    }

    public void EventHanlder()
    {
        Console.WriteLine("Metódo executado");
    }
}
