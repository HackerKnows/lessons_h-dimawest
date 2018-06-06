using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace секунды
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = 1;
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine(seconds);
                seconds = 1 + seconds;
            }
        }
    }
}
