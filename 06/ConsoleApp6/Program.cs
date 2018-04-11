using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите имя первого игрока");
            string name1 = Console.ReadLine();
            Console.WriteLine("введите рейтинг первого игрока");
            int rating1 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите имя второго игрока");
            string name2 = Console.ReadLine();
            Console.WriteLine("введите рейтинг второго игрока");
            int rating2 = int.Parse(Console.ReadLine());
            if (rating1 > rating2)
            {
                Console.WriteLine("результат сортировки " +name2 +" "+ name1);
            }
          else  {
                Console.WriteLine("результат сортировки " +name1 +" "+ name2);

            }
            Console.ReadLine();
        }
    }  
}
