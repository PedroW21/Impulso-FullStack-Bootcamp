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
        return this.Name = "Atacou com magia de Água";
    }

    public string Attack(int Bonus)
    {
        if (Bonus > 6)
        {
            return this.Name = "Realizou um ataque critico com magia de Água com um bônus de: " + Bonus;
        }
        else
        {
            return this.Name = "Realizou um ataque normal com magia de Água com um bônus de: " + Bonus;
        }
    }
}