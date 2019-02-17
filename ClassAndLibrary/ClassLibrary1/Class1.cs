using System;

namespace ClassLibrary1
{
    public class Calculation
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

        public int number1
        {
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
}
