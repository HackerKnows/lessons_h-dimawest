using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите кол - во очков полученных за матч");
            int score = int.Parse(Console.ReadLine());
            if (score == 3)
            {
                Console.WriteLine("выигрыш");
            }
            else if (score == 0)
            {
                Console.WriteLine("проигрыш");
            }
            else
            {
                Console.WriteLine("ничья");
            }
            Console.ReadLine();
        }
    }
}
