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
            Console.WriteLine("введите первое слово");
            string word = Console.ReadLine();
            Console.WriteLine("введите второе слово");
            string word2 = Console.ReadLine();
            Console.WriteLine("введите третье слово");
            string word3 = Console.ReadLine();
            Console.WriteLine( word3+" "+ word2+" "+ word+" ");
            Console.ReadLine();
        }
    }
}
