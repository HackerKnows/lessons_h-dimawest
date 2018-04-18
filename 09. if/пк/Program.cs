using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пк
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите цену компьютера в этом году");
            double pc = double.Parse(Console.ReadLine());
            Console.WriteLine("введите цену компьютера в прошлом году");
            double lastPc = double.Parse(Console.ReadLine());
            Console.WriteLine("введите цену консоли в этом году");
            double console = double.Parse(Console.ReadLine());
            Console.WriteLine("введите цену консоли в прощлом году");
           double lastConsole = double.Parse(Console.ReadLine());
            if(pc/lastPc<console/lastConsole)
            {
                Console.WriteLine("консоль подорожала больше");
            }
            else
            {
                Console.WriteLine("компьютер подорожал");
            }
            Console.ReadLine();
        }
    }
}
