using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = "apple";
            int quantity = 4;
            char firstLetter = 'C';
            bool isOpen = true;
            double cost = 1.96;
            decimal price = 0.49m;
            Console.Write($"I think the supermarket is open. If this is {isOpen} and I wish to purchase {fruit}s, I would need to go to isle {firstLetter}. ");
            Console.WriteLine($"Each {fruit} is ${price}, so {quantity} of them will cost me ${cost}.");
        }
    }
}

