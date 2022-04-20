using static System.Console;

class Program
{
    static void Main()
    {
        Hero Crono = new Hero("Crono", 47, "Lightning");

        WaterHero Marle = new WaterHero("Marle", 45, "Water");

        WriteLine(Crono.Attack());
        WriteLine(Marle.Attack());
    }
}