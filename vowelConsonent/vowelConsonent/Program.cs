using System;

namespace vowelConsonent
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            program.EvenOdd();
        }

        public void EvenOdd()
        {
            Console.WriteLine("Enter the alphabet");
            char alphabet = char.Parse(Console.ReadLine());
            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
            {
                Console.WriteLine("Alphabet is vowel");
            }
            else
            {
                Console.WriteLine("Alphabet is not a vowel");
            }
        }
            
        
    }
}
