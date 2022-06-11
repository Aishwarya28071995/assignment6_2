using System;

namespace powerOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.powerOf2();

        }

        public void powerOf2()
        {
            Console.WriteLine("Enter the value of N");
            int power = 1;
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                power = power * 2;
            }
            Console.WriteLine(power);
        }
            
        
    }
}
