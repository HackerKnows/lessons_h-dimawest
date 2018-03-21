using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("количество жителей");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine (amount);
            Console.WriteLine("введите его площадь");
            int area= int.Parse (Console.ReadLine());
            Console.WriteLine("плотность="+amount / area);
            Console.ReadLine();
        }
    }
}
