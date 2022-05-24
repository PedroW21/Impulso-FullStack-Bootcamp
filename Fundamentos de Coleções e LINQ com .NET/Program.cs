using static System.Console;

ListaColecoesGeneric();

static void ListaColecoesGeneric()
{
    // São "arrays de alto nivel", deixando mais dinamico (no tamanho, na sua manipulação e etc...)
    OperacoesLista opLista = new OperacoesLista();

    List<string> estados = new List<string>(); // poderia começar inicializado, basta colocar {"elements"};
    string[] estadosArray = new string[2] {"MG", "PR"};

    estados.Add("DF");
    estados.Add("GO");
    estados.Add("TO");

    WriteLine("Elementos originais da lista:");
    opLista.ImprimirLista(estados);

    estados.AddRange(estadosArray); // adiciona os elementos no final da coleção

    estados.Insert(3,"BA"); // inserir em um indice especifico

    WriteLine("\nElementos com a inclusão de outra lista nessa:");
    opLista.ImprimirLista(estados);

    // Removendo elementos de uma lista

    WriteLine("\nRemovendo o elemento...");
    estados.Remove("TO");
    opLista.ImprimirLista(estados);
}

static void ConvertendoTipoArray()
{
    OperacoesArray op = new OperacoesArray();

    int[] arr = new int[5] { 3, 8, 9, 1, 23 };

    string[] arrayString = op.ConverterArrayParaString(arr);

}

static void RedimensionaArray()
{
    OperacoesArray op = new OperacoesArray();

    int[] arr = new int[5] { 3, 8, 9, 1, 23 };

    //int valor = 10;
    
    WriteLine($"Capacidade atual do array: {arr.Length}");

    op.RedimensionarArray(ref arr, arr.Length*2);

    WriteLine($"Capacidade modificada do array: {arr.Length}");

}

static void EncontraIndiceElemento()
{
    OperacoesArray op = new OperacoesArray();

    int[] arr = new int[5] { 3, 8, 9, 1, 23 };

    int valorProcurado = 9;

    int indice = op.ObterIndice(arr, valorProcurado);

    if (indice > -1)
    {
        WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indice);
    }
    else
    {
        WriteLine("Valor não existente no array");
    }
}

static void EncontraElementoArray()
{
    OperacoesArray op = new OperacoesArray();

    int[] arr = new int[5] { 3, 8, 9, 1, 23 };

    int valorProcurado = 9;

    int valorAchado = op.ObterValor(arr, valorProcurado);

    if (valorAchado > 0)
    {
        WriteLine("Encontrei o valor");
    }
    else
    {
        WriteLine("Não encontrei o valor");
    }
}

static void VerificandoTodosElementosArray()
{
    OperacoesArray op = new OperacoesArray();

    int[] arr = new int[5] { 3, 8, 9, 1, 23 };

    int valorProcurado = 5;

    bool todosMaiorQue = op.TodosMaiorQue(arr, valorProcurado);

    if (todosMaiorQue)
    {
        WriteLine($"Todos são maior que o valor desejado | Valor: {valorProcurado}");
    }
    else
    {
        WriteLine($"Existe valores que não são maiores que o valor procurado | Valor: {valorProcurado}");
    }
}

static void EncontraElementoProcuradoEmArray()
{
    OperacoesArray op = new OperacoesArray();

    int[] arr = new int[5] { 3, 8, 9, 1, 23 };

    int valorProcurado = 10;
    bool existe = op.Existe(arr, valorProcurado);

    if (existe)
    {
        WriteLine($"Encontrei o valor procurado!!! É: {valorProcurado}");
    }
    else
    {
        WriteLine("Vai da não");
    }
}

static void OrdenarArrayComClassArray()
{
    OperacoesArray op = new OperacoesArray();

    int[] arr = new int[5] { 3, 8, 9, 1, 23 };

    WriteLine("--------------- Copiando um array ---------------");
    int[] arrCopy = new int[10];
    WriteLine("Array antes da copia: ");
    op.ImprimirArray(arrCopy);
    op.CopiaArray(ref arr, ref arrCopy);
    WriteLine("Array depois da copia: ");
    op.ImprimirArray(arrCopy);
    WriteLine("--------------- FIM ---------------");
}

static void OrdenandoComBubbleSort()
{
    OperacoesArray op = new OperacoesArray();

    int[] arr = new int[5] { 3, 8, 9, 1, 23 };

    WriteLine("--------------- Copiando um array ---------------");
    int[] arrCopy = new int[10];
    WriteLine("Array antes da copia: ");
    op.ImprimirArray(arrCopy);
    op.CopiaArray(ref arr, ref arrCopy);
    WriteLine("Array depois da copia: ");
    op.ImprimirArray(arrCopy);
    WriteLine("--------------- FIM ---------------");

    WriteLine("Array Original: \n");
    op.ImprimirArray(arr);

    WriteLine("\nArray ordenado: \n");
    // op.OrdernarBubbleSort(ref arr); // a classe array faz isso por baixo dos panos no metodo sort
    op.OrdenarComClasseArray(ref arr);
    op.ImprimirArray(arr);

}

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
