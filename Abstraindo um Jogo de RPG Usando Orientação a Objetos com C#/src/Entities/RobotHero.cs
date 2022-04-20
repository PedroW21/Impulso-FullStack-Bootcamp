public class RobotHero : Hero
{
    public RobotHero(string Name, int Level, string HeroType)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
    }

    public override string Attack()
    {
        return this.Name = "Atacou com seus punhos";
    }
    public string Attack(int Bonus)
    {
        if (Bonus < 3)
        {
            return this.Name = "O robo transforma seus braços em armas de alto calibre e lança um ataque em seus inimigos, recebebendo um bonus de: " + Bonus;
        }
        else if (Bonus < 6)
        {
            return this.Name = "O robo encontra algumas peças no chão e duplica seu tamanho, lançando um ataque forte em seus inimigos com um bonus de: " + Bonus;
        }
        else if (Bonus < 9)
        {
            return this.Name = "O robo começa a  soltar muito ar por seus parafusos, e se transforma em um megazorde que utiliza a fusão atomica para se mander de pe, e lança o poder de um sol em direção aos seus inimigos, causando um dano devastador com um bonus de: " + Bonus;
        }
        else
        {
            return this.Name = "O robo, começa a absorver a velocidade da luz, e lança um ataque avassalador em seus inimigos, com um bonus de: " + Bonus;
        }
    }
}
