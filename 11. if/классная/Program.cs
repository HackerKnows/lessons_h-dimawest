using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace классная
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите свой возраст ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 10 && age <= 20)
            {
                Console.WriteLine("ты подросток");
                
                
            }
            else
            {
                Console.WriteLine("ты не подросток");
            }
            Console.ReadLine();
        }
    }
}
