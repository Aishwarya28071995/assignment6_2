using System;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.LeapYear();
        }

        public void LeapYear()
        {
            int digits = 0;
            int remainder = 0;
            Console.WriteLine("Enter the year");
            long year = long.Parse(Console.ReadLine());
            while (year > 0)
            {
                remainder = (int)year % 10;
                digits++;
                year = year / 10;
            }

            if (digits == 4 && (year / 4) == 0 && (year % 100) != 0 && (year % 400) == 0)
            {
                Console.WriteLine("year is a leap year");
            }
            else
            {
                Console.WriteLine("Year is not a leap year");
            }
        }
            
        
    }
}
