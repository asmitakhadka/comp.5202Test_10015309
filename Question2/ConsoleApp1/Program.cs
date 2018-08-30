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
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("------The program will compute the average of ten numbers-----------");
            Console.WriteLine("--------------------------------------------------------------------");

            float total = 0;
            float average = 0;
            for(int a = 1; a<=10; a++)
            {
                Console.WriteLine($"Enter number {a}; ");
                total = total + float.Parse(Console.ReadLine());
                average = total / 10;
            }
            Console.WriteLine($"The average number is: {average}");
            
        }
    }
}
