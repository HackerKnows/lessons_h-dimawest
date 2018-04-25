using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите возраст дракона");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("введите здоровье дракона");
            int hp = int.Parse(Console.ReadLine());
            if(hp<50 || age < 150)
            
                {
                Console.WriteLine("нападай");
            }
            else
            {
                    Console.WriteLine("отступи,брат");
                }
            Console.ReadLine();
        }
    }
}
