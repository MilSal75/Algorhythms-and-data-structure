using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 101);
            while (true)
            {
                Console.WriteLine("Enter your try in [1,100]");
                int tries = 0;

                while (!int.TryParse(Console.ReadLine(), out tries))
                    Console.WriteLine("Error. Enter correct number in [1,100]");
                if (tries > number)
                    Console.WriteLine("Your try is more");
                else if (tries < number)
                    Console.WriteLine("Your try is less");
                else
                {
                    Console.WriteLine("You win");
                    break;
                }
            }
        }
    }
}
