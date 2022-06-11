using System;

namespace greater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Greatest();
        }

        public void Greatest()
        {
            int a = 10;
            int b = 20;
            int c = 30;

            if(a>b && a>c)
            {
                Console.WriteLine("a is greatest");
            }
            else if(b>a && b>c)
            {
                Console.WriteLine("b is greatest");
            }
            else
            {
                Console.WriteLine("c is greatest");
            }
        }
    }
}
