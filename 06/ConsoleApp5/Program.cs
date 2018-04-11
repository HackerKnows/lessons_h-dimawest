using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите сторону А");
            int sideA = int.Parse(Console.ReadLine());
            Console.WriteLine("введите сторону В");
            int sideB = int.Parse(Console.ReadLine());
            Console.WriteLine("введите сторону С");
            int sideC = int.Parse(Console.ReadLine());
            if(sideA+sideB>sideC)
            {
                Console.WriteLine("треугольник существует");
            }
            else   {
                Console.WriteLine("треугольник не существует");
            }
            Console.ReadLine();
        }
    }
}
