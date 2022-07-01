using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = "apple";
            int quantity = 4;
            char isleLetter = 'C';
            bool isOpen = true;
            double totalCost = 1.96;
            decimal unitPrice = 0.49m;
            Console.Write($"I think the supermarket is open. If this is {isOpen} and I wish to purchase {fruit}s, I would need to go to isle {isleLetter}. ");
            Console.WriteLine($"Each {fruit} is ${unitPrice}, so {quantity} of them will cost me ${totalCost}.");
        }
    }
}
