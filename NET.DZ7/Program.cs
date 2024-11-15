internal class Program
{
    struct Fraction
    {
        public int numerator;
        public int denominator;
        public int NOD(int x, int y)
        {
            if (y == 0) return x;
            return NOD(y, x % y);
        }
        public void input(int c, int z)
        {
            numerator = c;
            denominator = z;
        }
        public  void mult(int x)
        {
            numerator *= x;
            Console.WriteLine( "Fraction:  " + numerator+'/'+ denominator );
        }
        public  void div(int x)
        {
            denominator *= x;
            Console.WriteLine("Fraction:  " + numerator + '/' + denominator); 

        }

        public void sum(int x)
        {
            numerator += (x * denominator);
            Console.WriteLine("Fraction:  " + numerator + '/' + denominator);
        }
        public  void sub(int x)
        {
            numerator -= (x * denominator);
            Console.WriteLine("Fraction:  " + numerator + '/' + denominator);

        }
        public void show()
        {
            Console.WriteLine("Fraction:  " + numerator + '/' + denominator);
        }
        public  int peredacha()
        {
            return NOD(numerator, denominator);
        }
        public  void reduct(int x)
        {
            numerator /= x;
            denominator /= x;
        }

    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

}