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
            Console.WriteLine("введите сантиметры");
            int cm=int.Parse(Console.ReadLine());
            Console.WriteLine(cm/100);
            Console.ReadLine();
        }
    }
}
