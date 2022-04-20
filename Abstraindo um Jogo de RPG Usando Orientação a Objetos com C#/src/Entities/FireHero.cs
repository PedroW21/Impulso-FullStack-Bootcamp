public class FireHero : Hero
{
    public FireHero(string Name, int Level, string HeroType)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
    }

    public override string Attack()
    {
        return this.Name = "Atacou com sua arma";
    }
    public string Attack(int Bonus)
    {
        if (Bonus < 3)
        {
            return this.Name = "A heroina buscou em sua bolsa uma bujiganga, e sacou um lança-chamas, para atacar seus inimigos, recebebendo um bonus de: " + Bonus;
        }
        else if (Bonus < 6)
        {
            return this.Name = "A heroina jogou sua bolsa no chão, e mini granadas atômicas sairam de sua bolsa e explodiram seus inimigos, causando um dano normal com um bonus de: " + Bonus;
        }
        else if (Bonus < 9)
        {
            return this.Name = "A heroina encontrou em seus bolsos um controle somente com um botao, e ao clicar convocou um Raio laiser devastador, que picotou seus inimigos com um bonus de: " + Bonus;

        }
        else
        {
            return this.Name = "A heroina pegou um pequeno retangulo em sua cintura, que se transformou em uma arma, a qual sugava seus inimigos para um vacuo, causando um dano devastador com um bonus de: " + Bonus;
        }
    }
}
