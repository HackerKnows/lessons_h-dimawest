using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите рост");
            int growth = int.Parse(Console.ReadLine());
            Console.WriteLine("ввдите свой вес");
            int weight = int.Parse(Console.ReadLine());
            if (growth - 100 < weight)
            {
                Console.WriteLine("надо похудеть");
            }

            else
            {
                Console.WriteLine("не надо худеть");
            }
            Console.ReadLine();
        }
    }
}
