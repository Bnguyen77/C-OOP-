
using System;

namespace ClassAndLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.ICalculate function = new ClassLibrary1.Multiply();
            //ClassLibrary1.ICalculate subtractfunction = new ClassLibrary1.Subtract();
            //ClassLibrary1.ICalculate multiplyfunction = new ClassLibrary1.Multiply();
            //ClassLibrary1.ICalculate dividefunction = new ClassLibrary1.Divide();

            var result = function.performCal(10, 10);
            Console.WriteLine(result);

            //ClassLibrary1.Calculation calculation1 = new ClassLibrary1.Calculation(10, 5);
            //ClassLibrary2.Calculation calculation2 = new ClassLibrary2.Calculation();



            //calculation1.number1 = 10;
            //calculation1.number2 = 20;
            //Console.WriteLine("calculation1 (object1) now is " + calculation1.number3);
            //Console.WriteLine("calculation2 (object2) now is " + calculation2.number3);
            //Console.WriteLine("**************************");
            //Console.WriteLine("the addition is equal to {0}.", calculation1.addition(12, 23));
            //Console.WriteLine("the addition with no input values is equal to {0}.", calculation1.addition());
            //Console.WriteLine("**************************");
            //Console.WriteLine("the substraction is equal to {0}.", calculation1.subtraction(20, 10));
            //Console.WriteLine("the substraction with no input values is equal to {0}.", calculation1.subtraction());

        }
    }
}
