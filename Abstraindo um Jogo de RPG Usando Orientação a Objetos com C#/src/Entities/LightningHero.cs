public class LightningHero : Hero
{
    public LightningHero(string Name, int Level, string HeroType)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
    }

    public string Attack(int Bonus)
    {
        if (Bonus < 6)
        {
            return this.Name = "O héroi sentiu os atómos cheios de energia ao seu redor e lanço um ataque forte em seus inimigos com um bonus de" + Bonus;
        }
        else if (Bonus < 9)
        {
            return this.Name = "O héroi sentiu o tecido do tempo o chamar, e o invocou com toda sua furia em seus inimigos, com um ataque extremamente forte, tendo um bonus de" + Bonus;
        }
        else
        {
            return this.Name = "O héroi divinamente percebe que pode controlar o espaço, tendo criado um buraco negro para derrotar seus inimigos, tendo seu ataque critico um bonus de" + Bonus;
        }
    }
}
