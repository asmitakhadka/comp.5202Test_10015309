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
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("--------The program will expand a basic qudratic equation-------");
            Console.WriteLine("--------------------------(x+n)(x+m)----------------------------");
            Console.WriteLine("----------------------------------------------------------------");
            float n;
            float m;
            float equation = 0;

            Console.Write("Please enter a positive or negative value for n");
            n = float.Parse(Console.ReadLine());
            Console.Write("Please enter positive or negative value for m");
            m = float.Parse(Console.ReadLine());
            int x = int.(Console.Write());

            equation = ((x + n)(x + m));
            Console.WriteLine("The value in standard form: (equation)");
        }
    }
}
