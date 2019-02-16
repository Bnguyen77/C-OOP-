using System;

namespace WizNinSam
{
    public class Wizard : Human
    { 
        public Wizard (string name) : base(name)
        {
            Name = name;
            Intelligence = 25;
            Health = 50;
        }
        public void Heal()
        {
            Health += 10*Intelligence;
        }
        public void FireBall(Human target)
        {
            Random rand = new Random();
            target.Health -= rand.Next(20,51);
        }
    }
}
