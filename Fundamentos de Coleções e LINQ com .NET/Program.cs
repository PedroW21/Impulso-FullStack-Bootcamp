using static System.Console;




static void ArrayMatriz()
{
    int[,] matriz = new int[4, 2]
    {
    { 8 , 8 },
    { 10 , 20 },
    { 100 , 200 },
    { 50 , 500 }
    };

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            WriteLine(matriz[i, j]);
        }
    }

}

static void ArraySimples()
{
    int[] arrayInt = new int[3]; // array que guarda 3 elemtos | Declarando o array em C#

    arrayInt[0] = 128;
    arrayInt[1] = 256;
    arrayInt[2] = 512;

    // arrayInt[3] = 30; dara erro em tempo de execução
    // arrayInt[2] = "1"; - dara erro pelo intellisense (e na execução tb, mas o intelissense ja avisa)
    // correto = arrayInt[2] = int.Parse("1");

    for (int i = 0; i < arrayInt.Length; i++)
    {
        WriteLine($"For: {arrayInt[i]}");
    }

    foreach (var item in arrayInt)
    {
        WriteLine($"Foreach: {item}");
    }
}
