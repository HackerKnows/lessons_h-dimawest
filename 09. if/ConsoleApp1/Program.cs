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
            Console.WriteLine("введите растояние в километрах");
            double km = double.Parse(Console.ReadLine());
            Console.WriteLine("введите раастояние в футах");
            double foot = double.Parse(Console.ReadLine());
            double foots = foot * 0.305;
            if (km < foots)
            {
                Console.WriteLine(km);
            }  
            else
            {
                Console.WriteLine(foot);
            }
            Console.ReadLine();
        }
    }
}
