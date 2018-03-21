using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны квадрата");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine(side * 4);     
            Console.ReadLine();
        }
    }
}
