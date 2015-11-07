using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_Cat;

namespace Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new CatClass();
            cat.ChangeCatColor();
            int a;

            Console.WriteLine("Введит возраст кошки");
            Console.Write("Возраст кошки = ");
            cat.CatAge = int.Parse(Console.ReadLine());
            Console.WriteLine();

            bool access = false;

            do
            {
                Console.Clear();
                Console.Write("Имя кошки - ");
                Console.WriteLine(cat.Name);
                Console.Write("Возраст кошки - ");
                Console.WriteLine(cat.CatAge);
                Console.Write("Цвет кошки - ");
                Console.WriteLine(cat.CurrentColor);

                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1.Задать имя кошки\n2.Задать здоровый цвет кошки\n3.Задать больной цывет кошки\n4.Кормить\n5.Бить\n0.Выйти из меню");
                a = int.Parse(Console.ReadLine());
                int b;
                switch (a)
                {
                    case 1:
                        Console.Write("Введите имя кошки\n");
                        Console.Write("Имя кошки - ");
                        cat.Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Введите здоровый цвет кошки\n");
                        Console.Write("Здоровый цвет кошки - ");
                        cat.colors.HealthyColor = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Введите больной цвет кошки\n");
                        Console.Write("Больной цвет кошки - ");
                        cat.colors.SickColor = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("На сколько покромить кошку?\nЕды = ");
                        b = int.Parse(Console.ReadLine());
                        cat.Feed(b);
                        break;
                    case 5:
                        Console.Write("На сколько бить кошку?\nУдары = ");
                        b = int.Parse(Console.ReadLine());
                        cat.Punish(b);
                        break;
                    case 0:
                        Console.Clear();
                        access = true;
                        break;
                }
            } while (!access);
            Console.WriteLine("Вы вышли из меню, для закрытия программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
