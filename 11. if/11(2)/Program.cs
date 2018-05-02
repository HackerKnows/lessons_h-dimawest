using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первое число");
            double numberOne = double.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число");
            double numberTwo = double.Parse(Console.ReadLine());
            if (numberOne > 0 && numberTwo > 0 && numberOne > numberTwo)
            {
                Console.WriteLine(numberOne / 2);
            }
            else if (numberOne < 0 && numberTwo < 0 && numberTwo > numberOne)
            {
                Console.WriteLine(numberOne/2);
            }
            else
            {
                Console.WriteLine(numberOne);
            }
            Console.ReadLine();
        }
    }
}
