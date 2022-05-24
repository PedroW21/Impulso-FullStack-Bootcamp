public class OperacoesLista
{
    public void ImprimirLista(List<string> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            System.Console.WriteLine($"Índice na lista: {i} | Valor: {lista[i]}");
        }
    }
}
