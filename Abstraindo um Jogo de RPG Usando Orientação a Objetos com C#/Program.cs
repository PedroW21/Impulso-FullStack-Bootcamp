using static System.Console;

class Program
{
    static void Main()
    {
        LightningHero Crono = new LightningHero("Crono", 47, "Lightning");
        WaterHero Marle = new WaterHero("Marle", 45, "Water");
        FireHero Lucca = new FireHero("Lucca", 46, "Fire");
        RobotHero Robo = new RobotHero("Robo", 48, "Robot");


        WriteLine(Crono.Attack());
        WriteLine(Marle.Attack(3));
        WriteLine(Lucca.Attack(6));
        WriteLine(Robo.Attack(9));

    }
}