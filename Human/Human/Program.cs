using System;

namespace Human1
{
    public class Human
    {
        public string Name {get; set;}
        public int Strength {get; set;}
        public int Intelligence {get; set;}
        public int Dexterity {get; set;}
        public int Health {get; set;}
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }
        public void Attack(Human target)
        {
            target.Health -= Strength*5; 
        }
        static void Main(string[] args)
        {
            
            Human Oz = new Human("Oz",5,8,2,120);
            Human Binh = new Human("Binh");
            Binh.Attack(Oz);
            Binh.Attack(Oz);
            Binh.Attack(Oz);
            Console.WriteLine(Oz.Health);
            Console.Write(Oz.Strength);
            Console.Write(Oz.Intelligence);
            
        }
    }
}
