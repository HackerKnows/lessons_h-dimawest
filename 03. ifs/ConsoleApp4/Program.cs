using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals Fox = new Animals( "мясо", 4);
            Animals Bird = new Animals( "хлеб", 3);
            Animals Ezhik = new Animals( "яблоко", 1);


            Food Apple = new Food(5);
            Food Bred = new Food(7);
            Food Meat = new Food(15);
            Food Morkovka = new Food(10);


            Fox.eat(Meat.get_step());
            Console.WriteLine(Fox.get_check_hungry());
            while(Fox.get_check_hungry()< 20)
            {
                Console.WriteLine("Лиса - Покорми меня еще");
                int m = Fox.eat(Apple.get_step()) ;
                Console.WriteLine(m);
            }


            Bird.eat(Bred.get_step());
            Console.WriteLine(Bird.get_check_hungry());
            while (Bird.get_check_hungry() < 20)
            {
                Console.WriteLine("Птичка - Покорми меня еще");
                int n = Bird.eat(Morkovka.get_step());
                Console.WriteLine(n);
            }


            Ezhik.eat(Apple.get_step());
            Console.WriteLine(Ezhik.get_check_hungry());
            while (Ezhik.get_check_hungry() < 20)
            {
                Console.WriteLine("Ежик - Покорми меня еще");
                int s =  Ezhik.eat(Morkovka.get_step());
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
    class Animals
    {
        private int not_hungry = 0 ;
        public int get_check_hungry()
        {
            if (not_hungry >= 20)
            {
                
                Console.WriteLine("Животное накормлено");
            }
            else
            {
                Console.WriteLine("Покорми меня еще");
            }
            return not_hungry;
        }
        private string favourite_food;
        private int kletka;

       public int eat(int step)
        {
            if (choose_food())
            {
                not_hungry = not_hungry + step;
            }
            return not_hungry;
        }

        public Animals(string Favourite_food, int Kletka)
        {
      
            favourite_food = Favourite_food;
            kletka = Kletka;
        }
        public bool choose_food()
        {
            String[] Food = new String[4] { "морковка", "хлеб", "яблоко", "мясо" };
            Console.WriteLine("Какую еду ты выберешь?");
            bool fav=false;
            for (int i = 0; i < 4; i++)
            {
                if (Food[i] == favourite_food)
                {

                   fav =  true;
                }
            }
            return fav;
        }

    }
    class Food
    {
        private int step;
        public int get_step()
        {
            return step;
        }
        public Food(int Step)
        {
            step = Step;
        }

    }

}
