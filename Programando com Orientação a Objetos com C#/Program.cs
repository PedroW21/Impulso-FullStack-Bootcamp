using static System.Console;

ICalculadora calc = new Calculadora(); // ICalculadora não pode ser instanciado por ser uma Interface

WriteLine(calc.Somar(10,20));
WriteLine(calc.Subtrair(10,20));
WriteLine(calc.Dividir(20,10));
WriteLine(calc.Multiplicar(10,20));


static void ClasseSystemObject()
{
    Computador comp = new Computador();
    WriteLine(comp.ToString()); // metodo herdado da classe Object
}

static void ExemploMetodoAbstrato()
{
    Corrente c = new Corrente();

    c.Creditar(100);
    c.ExibirSaldo();
}

static void PolimorfismoEarlyBiding()
{
    Calculadora calc = new Calculadora();

    WriteLine("Resultado 1ª primeira soma: " + calc.Somar(1, 4)); // há um metodo em sobrecarga
    WriteLine("Resultado da 2ª soma: " + calc.Somar(1, 4, 9));

}

static void ExemploPolimorfismoSobrescrito()
{

    Aluno student = new Aluno();

    student.Nome = "Baby Boo";
    student.Idade = 25;
    student.Nota = 1000;

    student.Mostrar(); // metodo sobrescrito (via herança) - polimorfismo em tempo de exec

    Professor prof = new Professor();

    prof.Nome = "Jubilei";
    prof.Idade = 38;
    prof.Salario = 780;

    prof.Mostrar(); // metodo sobrescrito (via herança) - polimorfismo em tempo de exec

}

static void ExemploHerança()
{
    Aluno aluno = new Aluno();

    aluno.Nome = "Jubiscreia"; //herdou
    aluno.Idade = 24; //herdou
    aluno.Nota = 8.9; // So de aluno

    Professor prof = new Professor();

    prof.Nome = "Jubileu"; //herdou
    prof.Idade = 41; //herdou
    prof.Salario = 3860; // so de prof

}

static void ExemploEncapsulamento()
{ // Propriedades inacessiveis (privadas), sendo "alterável" por meio de get e set e se forem válidos
    Retangulo r = new Retangulo();

    // Valores válidos
    r.DefinirMedidas(10, 10);

    WriteLine($"Área: {r.ObterArea()}m²");

}

static void ExemploAbstracao()
{
    Pessoa p1 = new Pessoa();

    p1.Nome = "Iriney";
    p1.Idade = 17;

    p1.Mostrar();
}
