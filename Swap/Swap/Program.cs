using System;

namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            program.Swap();
        }

        public void Swap()
        {
            int a = 20;
            int b = 30;
            Console.WriteLine("Number a before swapping" + a);
            Console.WriteLine("Number b before swapping" + b);
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Number a after swapping" + a);
            Console.WriteLine("Number b after swapping" + b);
        }
            

        
    }
}
