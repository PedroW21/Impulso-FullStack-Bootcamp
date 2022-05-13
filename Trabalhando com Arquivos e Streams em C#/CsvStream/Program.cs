using static System.Console;

CriarCsv();

WriteLine("\n\nPressione ENTER para sair...");
ReadLine();

static void CriarCsv()
{

    var path = Path.Combine(Environment.CurrentDirectory, "Entrada");

    var pessoas = new List<Pessoa>(){
        new Pessoa() {
            Nome = "Irineu Tadeu",
            Email = "itu@itu.com",
            Telefone = 64987428,
            Nascimento = new DateOnly(year: 1973, month: 9, day: 12)
        },
        new Pessoa() {
            Nome = "Raquel Tramoia",
            Email = "rta@rta.com",
            Telefone = 98457129,
            Nascimento = new DateOnly(year: 1465, month: 1, day: 21)
        },
        new Pessoa() {
            Nome = "Tadeu Correu",
            Email = "tcu@tcu.com",
            Telefone = 28420177,
            Nascimento = new DateOnly(year: 1329, month: 4, day: 17)
        },
        new Pessoa() {
            Nome = "Simone Iphone",
            Email = "sie@sie.com",
            Telefone = 471587209,
            Nascimento = new DateOnly(year: 2015, month: 7, day: 29)
        },
        new Pessoa() {
            Nome = "Lucas Labutas",
            Email = "lls@lls.com",
            Telefone = 65987266,
            Nascimento = new DateOnly(year: 2099, month: 12, day: 2)
        },
    };

    var di = new DirectoryInfo(path);

    if(di.Exists) {
        di.Create();
        path = Path.Combine(path, "usuarios.csv");
    }

    using var sw = new StreamWriter(path);
    sw.WriteLine("nome,email,telefone,nascimento");

    foreach (var pessoa in pessoas)
    {
        var linha = $"{pessoa.Nome}, {pessoa.Email}, {pessoa.Telefone}, {pessoa.Nascimento}";

        sw.WriteLine(linha);
    }

};


static void LerCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "usuarios-exportacao.csv");

    if (File.Exists(path))
    {
        using var sr = new StreamReader(path);

        var cabecalho = sr.ReadLine()?.Split(","); // ? = se for nulo, ignore a proxima instrução

        while (true)
        {
            var registro = sr.ReadLine()?.Split(",");

            if (registro == null) break;

            if (cabecalho.Length != registro.Length)
            {
                WriteLine($"Arquivo fora do padrão!!");
                break;
            }

            for (int i = 0; i < registro.Length; i++)
            {
                WriteLine($"{cabecalho?[i]}:{registro[i]}");
            }

            WriteLine("----------&----------");
        }

        WriteLine("\n\nPressione ENTER para sair...");
        ReadLine();

    }
    else
    {
        WriteLine($"{path} não existe!! \n\nPressione enter para sair...");
        ReadLine();
    }
}

class Pessoa
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Telefone { get; set; }
    public DateOnly Nascimento { get; set; }

}
