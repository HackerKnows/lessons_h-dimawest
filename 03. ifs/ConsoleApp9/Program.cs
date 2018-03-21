using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("количество дней прошедших с начала года");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine("прошло недель"+ days / 7);
            Console.ReadLine();
        }
    }
}
