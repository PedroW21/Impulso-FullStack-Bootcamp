﻿internal class Program
{
    static AnimeRepositorio repositorio = new AnimeRepositorio();
    private static void Main(string[] args)
    {
        string opcaoUsuario = ObterOpcaoUsuario();

        while (opcaoUsuario.ToUpper() != "X")
        {
            switch (opcaoUsuario)
            {
                case "1":
                    ListarAnimes();
                    break;

                case "2":
                    InserirAnime();
                    break;

                case "3":
                    AtualizarAnime();
                    break;

                case "4":
                    ExcluirAnime();
                    break;

                case "5":
                    VisualizarAnime();
                    break;

                case "C":
                    Console.Clear();
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            opcaoUsuario = ObterOpcaoUsuario();
        }

    }

    private static void ExcluirAnime()
    {
        Console.Write("Digite o id do Anime: ");
        int indiceAnime = int.Parse(Console.ReadLine());

        repositorio.Exclui(indiceAnime);
    }

    private static void VisualizarAnime()
    {
        Console.Write("Digite o id do Anime: ");
        int indiceAnime = int.Parse(Console.ReadLine());

        var anime = repositorio.RetornaPorId(indiceAnime);

        Console.WriteLine(anime);
    }

    private static void AtualizarAnime()
    {
        Console.Write("Digite o id do Anime: ");
        int indiceAnime = int.Parse(Console.ReadLine());

        // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
        // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
        foreach (int i in Enum.GetValues(typeof(Genero)))
        {
            Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
        }
        Console.Write("Digite o gênero entre as opções acima: ");
        int entradaGenero = int.Parse(Console.ReadLine());

        Console.Write("Digite o Título da Série: ");
        string entradaTitulo = Console.ReadLine();

        Console.Write("Digite o Ano de Início da Série: ");
        int entradaAno = int.Parse(Console.ReadLine());

        Console.Write("Digite a Descrição da Série: ");
        string entradaDescricao = Console.ReadLine();

        Animes atualizaAnime = new Animes(id: indiceAnime,
                                    genero: (Genero)entradaGenero,
                                    titulo: entradaTitulo,
                                    ano: entradaAno,
                                    descricao: entradaDescricao);

        repositorio.Atualiza(indiceAnime, atualizaAnime);
    }

    private static void ListarAnimes()
    {
        Console.WriteLine("Listar animes");
        var lista = repositorio.Lista();

        if (lista.Count == 0)
        {
            Console.WriteLine("Nenhum anime cadastrado. ");
            return;
        }

        foreach (var anime in lista)
        {
            Console.WriteLine("#ID {0}: - {1}", anime.RetornaId(), anime.RetornaTitulo());
        }
    }

    private static void InserirAnime()
    {
        Console.WriteLine("Inserir novo anime");
        foreach (int i in Enum.GetValues(typeof(Genero)))
        {
            Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
        }

        Console.WriteLine("Digite o genêro entre as opcões acima: ");
        int entradaGenero = int.Parse(Console.ReadLine());

        Console.Write("Digite o Titulo da Anime: ");
        string entradaTitulo = Console.ReadLine();

        Console.Write("Digite o Ano de Inicio da Anime: ");
        int entradaAno = int.Parse(Console.ReadLine());

        Console.Write("Digite a Descrição da Anime: ");
        string entradaDescricao = Console.ReadLine();

        Animes novoAnime = new Animes(id: repositorio.ProximoId(),
        genero: (Genero)entradaGenero,
        titulo: entradaTitulo,
        ano: entradaAno,
        descricao: entradaDescricao);

        repositorio.Insere(novoAnime);
    }


    private static string ObterOpcaoUsuario()
    {
        Console.WriteLine();
        Console.WriteLine("DIO Animes a seu dispor!");
        Console.WriteLine("Informe a opção desejada: ");
        Console.WriteLine("1- Listar Animes");
        Console.WriteLine("2- Inserir novo anime");
        Console.WriteLine("3- Atualizar anime");
        Console.WriteLine("4- Excluir anime");
        Console.WriteLine("5- Visualizar anime");
        Console.WriteLine("C- Limpar Tela");
        Console.WriteLine("X- Sair");

        Console.WriteLine();

        string opcaoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return opcaoUsuario;
    }

}