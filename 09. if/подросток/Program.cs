using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace подросток
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите свой возраст");
            int age = int.Parse(Console.ReadLine());
            if (age >= 10)
            { 
                if (age <= 20)
                {
                    Console.WriteLine("ты подросток");
                }
            }
            Console.ReadLine();
        }
    }
}
