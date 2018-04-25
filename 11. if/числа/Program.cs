using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace числа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число one");
            int one = int.Parse(Console.ReadLine());
            Console.WriteLine("введите число two");
            int two = int.Parse(Console.ReadLine());
            Console.WriteLine("введите число three ");
            int three = int.Parse(Console.ReadLine());
            if(one>two &&one> three)
            {
                Console.WriteLine("число one больше");
            }
            else if(two>one && two > three)
            {
                Console.WriteLine("число two больше ");
            }
            else
            {
                Console.WriteLine("число three больше");
            }
            Console.ReadLine();
        }
    }
}
