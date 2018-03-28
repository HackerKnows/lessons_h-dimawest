using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace стоймость_килограмма
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("стоймость килограмма конфет");
            int candy = int.Parse(Console.ReadLine());
            Console.WriteLine("сколько хотите купить килограмм");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine(candy * weight);
            Console.ReadLine();
        }
    }
}
