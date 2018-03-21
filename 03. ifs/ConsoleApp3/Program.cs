using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите радиус");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine(3*radius*radius);
            Console.ReadLine();

        }
    }
}
