namespace WizNinSam
{
    public class Ninja : Human
    {
        public Ninja(string name): base(name)
        {
            Name = name;
            Dexterity = 175;
        }
        public void Stealth(Human target)
        {
            target.Health -= 3*Strength;
            Health += 10;
        }
        public void Getaway()
        {
            Health -= 15;
        }
    }
}
