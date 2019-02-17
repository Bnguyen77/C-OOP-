namespace ClassLibrary1
{
    public class Add : ICalculate
    {
        public int performCal(int n1, int n2)
        {
            return n1 + n2;
        }
    }
    public class Subtract : ICalculate
    {
        public int performCal(int n1, int n2)
        {
            return n1 - n2;
        }
    }
    public class Multiply : ICalculate
    {
        public int performCal(int n1, int n2)
        {
            return n1 * n2;
        }
    }
    public class Divide : ICalculate
    {
        public int performCal(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
