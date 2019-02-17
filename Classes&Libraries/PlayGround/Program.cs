using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation1 = new Calculation(10, 5);
            Calculation calculation2 = new Calculation();

            //calculation1.number1 = 10;
            //calculation1.number2 = 20;
            Console.WriteLine("calculation1 (object1) now is " + calculation1.number3);
            Console.WriteLine("calculation2 (object2) now is " + calculation2.number3);
            Console.WriteLine("**************************");
            Console.WriteLine("the addition is equal to {0}.",  calculation1.addition(12, 23) );
            Console.WriteLine("the addition with no input values is equal to {0}.", calculation1.addition());
            Console.WriteLine("**************************");
            Console.WriteLine("the substraction is equal to {0}.", calculation1.subtraction(20, 10));
            Console.WriteLine("the substraction with no input values is equal to {0}.", calculation1.subtraction());

        }
    }
}
