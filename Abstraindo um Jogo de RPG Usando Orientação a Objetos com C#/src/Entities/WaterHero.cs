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
}