using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround
{
    class Calculation
    {
        public Calculation()// constructor with pre-define value
        {
            _number1 = 20;
            _number2 = 5;
        }
        public Calculation(int number1, int number2) //constructor that expect 2 values
        {
            _number1 = number1;
            _number2 = number2;
        }

        private int _number1 = 0;
        private int _number2 = 0;
        private int _number3 = 0;

        public int number1 {
            get { return _number1; }
            set { _number1 = value; }
        }

        public int number2
        {
            get { return _number2; }
            set { _number2 = value; }
        }

        public int number3
        {
            get { return _number1 + _number2; }
        }

        public int addition(int number1, int number2) //Method
        {
            return number1 + number2;
        }

        public int addition()
        {
            return _number1 + _number2;
        }

        public int subtraction(int number1, int number2) //Method
        {
            return number1 - number2;
        }


        public int subtraction()
        {
            return _number1 - _number2;
        }



    }
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
