using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace стороны_треугольника
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите сторону А ");
            int sideA = int.Parse(Console.ReadLine());
            Console.WriteLine("введите сторону Б ");
            int sideB = int.Parse(Console.ReadLine());
            Console.WriteLine("введите сторону С ");
            int sideC = int.Parse(Console.ReadLine());
            if (sideA * sideA + sideB * sideB == sideC * sideC)
            {
                Console.WriteLine("треугольник прямоугольный"); 
            }
          else  {
                Console.WriteLine("треугольник не прямоугольный");
            }
            Console.ReadLine();
        }
    }
}
