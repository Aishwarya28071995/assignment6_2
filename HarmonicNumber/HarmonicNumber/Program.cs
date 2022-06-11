using System;

namespace HarmonicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N");
            int N = Int32.Parse(Console.ReadLine());
            float sum = 0;
            for(float i=1;i<=N;i++)
            {
                sum = sum + (1 / i);
            }
            Console.WriteLine(sum);
        }
    }
}
