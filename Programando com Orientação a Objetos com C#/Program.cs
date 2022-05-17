using static System.Console;




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
