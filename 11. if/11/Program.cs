using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine(number * -1);
            }
            else
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
