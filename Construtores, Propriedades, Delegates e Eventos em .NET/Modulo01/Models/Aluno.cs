public class Aluno : Pessoa
{
    // obedecendo as regras de herança, onde herdo obrigatoriamente suas propriedades, e as repasso por meio do base()
    public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome) 
    {
        Console.WriteLine("Construtor da classe aluno!!");
    }
}
