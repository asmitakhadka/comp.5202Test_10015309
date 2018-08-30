using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Random random = new Random();
            int myi = random.Next(1, 1000);

            Console.WriteLine("Please enter an integer between 1 and 1000");

            i = int.Parse(Console.ReadLine());

            if (i % 2 <= 1000)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
    
