using static System.Console;


Pessoa p1 = new Pessoa();

p1.Nome = "Pierre";
p1.Idade = 19;
p1.EnderecoPessoa = new Endereco() {
    Logradouro = "Rua Iriney",
    Cidade = "Irinestro",
    CEP = "77777-000",
    Numero = 1299
};

WriteLine("Fim XD");

// Tiramos a necessidade do garbage colector, tornando a aplicação mais rápida (pois garantimos que ela não ira para HEAP);