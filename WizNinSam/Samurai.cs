namespace WizNinSam
{
    public class Samurai : Human
    {
        public Samurai (string name) : base(name)
        {
            Name = name;
            Health = 200;
        }
        public void deathBlow(Human target)
        {
            if (target.Health <= 50)
            {
                target.Health = 0;
            }
            if (target.Health > 50)
            {
                target.Health -= 2*Strength;
            }

        }
        public void Meditate()
        {
            Health = 200;
        }
    } 
}
