using System;

namespace PhoneC_
{

    class Program
    {
        static void Main(string[] args)
        {
            Galaxy S9 = new Galaxy("S9", 90, "TMobile","blablablabla");
            Nokia Don = new Nokia("1100", 101, "TMobile","pew pew pew");
            
            S9.DisplayInfo();
            System.Console.WriteLine(S9.Ring());
            System.Console.WriteLine(S9.Unlock());
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            Don.DisplayInfo();
            System.Console.WriteLine(Don.Ring());
            System.Console.WriteLine(Don.Unlock());
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            
        }
    }
}
