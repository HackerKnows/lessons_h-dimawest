using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace покупка
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите свой баланс");
            int balance = int.Parse(Console.ReadLine());
            if (balance > 3000)
            {
                Console.WriteLine("баланса хватает");
            }
            else
            {
                Console.WriteLine("не хватает денег на балансе");
            }
            Console.ReadLine();
        }
    }
}
