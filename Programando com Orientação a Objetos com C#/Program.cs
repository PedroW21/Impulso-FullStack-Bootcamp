using static System.Console;

Aluno aluno = new Aluno();

aluno.Nome = "Jubiscreia"; //herdou
aluno.Idade = 24; //herdou
aluno.Nota = 8.9; // So de aluno

Professor prof = new Professor();

prof.Nome = "Jubileu"; //herdou
prof.Idade = 41; //herdou
prof.Salario = 3860; // so de prof

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
