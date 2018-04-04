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
            Console.WriteLine("введите стоимость монитора");
            int cost = int.Parse(Console.ReadLine());
            Console.WriteLine("стоимость системного блока");
            int systemunit = int.Parse(Console.ReadLine());
            Console.WriteLine("введите стоимость клавиатуры и мыши");
            int keyboardmouse = int.Parse(Console.ReadLine());
            Console.WriteLine(cost + systemunit + keyboardmouse);
            Console.ReadLine();
        }
    }
}
