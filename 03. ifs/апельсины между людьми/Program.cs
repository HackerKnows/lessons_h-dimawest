using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace апельсины_между_людьми
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количество апельсинов");
            int orange = int.Parse(Console.ReadLine());
            Console.WriteLine("введите кол - во людей");
            int people = int.Parse(Console.ReadLine());
            Console.WriteLine(orange / people);
            Console.ReadLine();
        }
    }
}
