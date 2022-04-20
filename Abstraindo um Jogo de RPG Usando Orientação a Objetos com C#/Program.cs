using static System.Console;

class Program
{
    static void Main()
    {
        LightningHero Crono = new LightningHero("Crono", 47, "Lightning");

        WaterHero Marle = new WaterHero("Marle", 45, "Water");

        WriteLine(Crono.Attack());
        WriteLine(Marle.Attack());
        WriteLine(Marle.Attack(3));
        WriteLine(Marle.Attack(8));

    }
}