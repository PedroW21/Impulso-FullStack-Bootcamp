public class WaterHero : Hero
{
    public WaterHero(string Name, int Level, string HeroType)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
    }
    public override string Attack()
    {
        return this.Name = "Atacou com sua balestra";
    }

    public string Attack(int Bonus)
    {
        if (Bonus < 3)
        {
            return this.Name = "A heroina ouviu a voz de um yete em uma linguagem desconhecida, e lançou uma flecha magica com mini cristais de gelo, recebebendo um bonus de : " + Bonus;
        }
        else if (Bonus < 6)
        {
            return this.Name = "A heroina sentiu em seu redor um ar gelado, e lançou um ataque de multiplas facas de gelo em seus inimigos, com um bonus de : " + Bonus;
        }
        else if (Bonus < 9)
        {
            return this.Name = "A heroina sentiu seu coração pulsar mais 1000x mais rapidamente, e acabou lançando um meteoro de nitrogenio liquefeito em seus inimigos, causando um enorme dano com um bonus de : " + Bonus;

        }
        else
        {
            return this.Name = "A heroina, clamando por poder, realiza um pequeno corte em sua mão e começa a manipular seu sangue e de qualquer um, causando um dano devastador em seus inimigos, com um bonus de: " + Bonus;
        }
    }
}