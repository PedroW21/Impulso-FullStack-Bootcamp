    public class Crono
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public string HeroType { get; set; }

        public Crono(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
    }
