public class Calculadora
{
    public delegate void DelegateCalculadora();

    // Evento
    public static event DelegateCalculadora EventoCalculadora;
    
    public static void Somar(int x, int y)
    {   
        if(EventoCalculadora != null)
        {
        Console.WriteLine($"Soma: {x+y}");
        }
        else
        {
            Console.WriteLine("Nenhum escrito");
        }
    }

    public static void Subtrair(int x, int y)
    {
        Console.WriteLine($"Subtrair: {x-y}");
    }
}
