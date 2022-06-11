using System;

namespace HeadAndTail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.HeadAndTail();

        }

        public void HeadAndTail()
        {
            Console.WriteLine("Enter number of times to flip the coin");
            int value = Int32.Parse(Console.ReadLine());
            float tail = 0;
            float head = 0;
            for (int i = 1; i <= value; i++)
            {
                Random random = new Random();
                int number = random.Next(0, 2);
                if (number == 0)
                {
                    tail = tail + 1;
                    Console.WriteLine("Percentage of tail is " + (tail / value) * 100);
                }
                if (number == 1)
                {
                    head = head + 1;
                    Console.WriteLine("Percentage of head is " + (head / value) * 100);
                }

            }
        
            
        }
    }
}
