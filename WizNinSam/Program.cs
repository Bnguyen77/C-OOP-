using System;

namespace WizNinSam
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Ninja Binh = new Ninja("Binh"); 
            Ninja Hao = new Ninja("Hao"); 
            Wizard Ph = new Wizard("Ph");
            Hao.Stealth(Binh);
            Ph.FireBall(Hao);
            
        }
    }
}
