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
            Console.WriteLine("введите проценты кислорода");
            int oxygen = int.Parse(Console.ReadLine());
            Console.WriteLine("введите температуру на планете ");
            int temperature = int.Parse(Console.ReadLine());
            if (oxygen > 20 && temperature > 15)
            {
                Console.WriteLine("планета  пригодна для колонизации");
            }
            else
            {
                Console.WriteLine("не пригодна для жизни");
            }
            Console.ReadLine();
        } 
    }
}
