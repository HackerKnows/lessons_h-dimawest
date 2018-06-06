using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace супер_квест
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ты - супергерой.Твоя задача - вызволить принцессу из плена Всемирной Сети, куда она попала, по неосторожности ткнув в рекламный баннер.В самом начале ты только - только получил известие о неприятности, и стоишь перед выбором");
            Console.WriteLine("1.Поиграть в Доту");
            Console.WriteLine("2.Узнать, на каком сайте она застряла");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("Ты просидел в Доте до утра, и принцессу спас другой хакер");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (number == 2)
            {
                Console.WriteLine(" принцессе пришло письмо с рекламой суперстойкой помады, и там был баннер со ссылкой на сайт dontclickme.noob");
            }
            Console.WriteLine("1.Послушаться совета в адресе сайта и поиграть в Доту");
            Console.WriteLine("2.Перейти на сайт");
            Console.WriteLine("3.Обновить антивирус, а потом перейти на сайт");
            int number2 = int.Parse(Console.ReadLine());
            if (number2 == 1)
            {
                Console.WriteLine("конец игры, проигрыш - другой хакер спас принцессу");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (number2 == 2)
            {
                Console.WriteLine("конец игры, проигрыш - ты заразился тем же вирусом, что и принцесса, ты застрял на том же сайте со сломанным компьютером");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (number == 3)
            {
                Console.WriteLine("Игрок встречает противника - Капча-Монстра, который не дает обновить антивирус. Чтобы его победить, нужно решить задачку: сколько будет 2 + 2 * 2? Варианты поведения:");
            }
            Console.WriteLine("1.А, ну ее, математика для нубов! Пойду в Доту поиграю!");
            Console.WriteLine("2.Проверить исходный код Капча - Монстра");
            Console.WriteLine("3.Ответить монстру: 6");
            int number3 = int.Parse(Console.ReadLine());
            if (number3 == 1)
            {
                Console.WriteLine("конец игры, проигрыш - другой хакер спас принцессу");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (number3 == 2)
            {
                Console.WriteLine("Игрок вскрывает код Капча-Монстра и видит, что тот печатает черным цветом некоторые символы. Ух ты! Их не видно на черном фоне! Варианты поведения:");
            }
            if (number3 == 3)
            {
                Console.WriteLine("конец игры, проигрыш - было бы слишком легко выиграть! На самом деле там невидимые скобки - это и есть супер-способность Капча-Монстра! Задание выглядит как (2 + 2) * 2)");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("1.Круто, пойду попробую так в своей программе!");
            Console.WriteLine("2.Ответить монстру: 6");
            Console.WriteLine("3.Заменить цвет всех черный символов на белый и перезагрузить Капчу-Монстра ");
            int number4 = int.Parse(Console.ReadLine());
            if (number4 == 1)
            {
                Console.WriteLine("конец игры, проигрыш - принцесса заблудилась во Всемирной Сети, пока герой ковырялся не там, где надо");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (number4 == 2)
            {
                Console.WriteLine("конец игры, проигрыш - зря, что ли, подвох находил??");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (number4 == 3)
            {
                Console.WriteLine("Капча - Монстра хрипит консольными командами, догружается, наконец, до конца и выдает: сколько будет(2 + 2) * 2");
            }
            Console.WriteLine("1.Ответить монстру: 8");
            Console.WriteLine("2.Герою лень считать, и он идет в Доту ");
            int number5 = int.Parse(Console.ReadLine());
            if (number5 == 1)
            {
                Console.WriteLine("Капча-Монстр обиженно сопит: Как ты догадался ? Я же спрятал скобки!, отступает и позволяет обновить антивирус. Теперь герой защищен, и может перейти на сайт! Едва он делает это, как получает сообщение антивируса: Замечена и заблокирована вредоносная программа: WinLock 1.0.Файл - лекарство можно найти здесь: C:\\Antiviruscure.exe. Варианты действий");
            }
            if (number5 == 2)
            {
                Console.WriteLine("конец игры, проигрыш - другой хакер спас принцессу");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("1.Отправить лекарство принцессе по почте и пойти в Доту");
            Console.WriteLine("2.Записать лекарство на флешку и пойти к принцессе/принцу домой");
            int number6 = int.Parse(Console.ReadLine());
            if (number6 == 1)
            {
                Console.WriteLine("конец игры, проигрыш - у нее сломался компьютер, она не может получить твой файл!принцессу спасает другой хакер");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("победа!");
            Console.ReadLine();
        }
    }
}
