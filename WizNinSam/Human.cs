namespace WizNinSam
{
    public class Human
    {
        public string Name;
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public Human(string name)
        {
            Name = name;
            Health = 100;
            Strength = 3;
            Dexterity = 3;
            Intelligence = 3;
        }
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }
    }
}
