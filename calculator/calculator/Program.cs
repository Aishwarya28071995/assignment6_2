using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dividend");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the divisor");
            int m = Int32.Parse(Console.ReadLine());


            int remainder = n % m;
            int quotient = n / m;

            Console.WriteLine("remainder is" + remainder);
            Console.WriteLine("quotient is" + quotient);
        }
    }
}
