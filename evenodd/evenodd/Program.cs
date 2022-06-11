using System;

namespace evenodd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            program.Evenodd();
        }

        public void Evenodd()
        {
            Console.WriteLine("Enter the number");
            int n = Int32.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("NUmber is a even number");
            }
            else
            {
                Console.WriteLine("Number is a odd number");
            }
        }

          
        
    }
}
