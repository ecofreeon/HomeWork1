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
            int menu;
            int age;
            int submenu = 4;
            Console.WriteLine("\n1 - купить кота");
            menu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            while (true)
            {
                switch (menu)
                {
                    case 1:

                        Console.WriteLine("\nустановить возраст");
                        Console.WriteLine("\nустановить возраст иожно лишь единожды");
                        age = Convert.ToInt32(Console.ReadLine());
                        if (age == 0)
                        {
                            Console.Clear();
                            Console.WriteLine(" возраст кота не может быть 0");
                        }
                        else
                        {

                            var cat1 = new Cat(age, 5, "зеленый", "белый");
                            while (menu != 0)
                            {

                                Console.Clear();
                                if (string.IsNullOrEmpty(cat1.Name) == false)
                                    Console.WriteLine(string.Format("\nимя кота " + cat1.Name));
                                Console.WriteLine(string.Format("cat's age is " + cat1.Age));
                                if (string.IsNullOrEmpty(cat1.CurrentColor) == false)
                                    Console.WriteLine(string.Format("текущий цвет кота " + cat1.CurrentColor));
                                Console.WriteLine("................................................................");
                                Console.WriteLine("1 - установить имя ");
                                Console.WriteLine("2 - установить цвет ");
                                Console.WriteLine("3 - бить ");
                                Console.WriteLine("4 - кормить ");
                                menu = Convert.ToInt32(Console.ReadLine());
                                switch (menu)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("установить имя кота");
                                        Console.WriteLine("\nвы можете установить имя кота лишь единожды");
                                        if (string.IsNullOrEmpty(cat1.Name) == true)
                                            cat1.Name = Console.ReadLine();
                                        else
                                        {
                                            while (submenu != 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("имя кота уже установлено");
                                                Console.WriteLine("0 для выхода");
                                                submenu = Convert.ToInt32(Console.ReadLine());
                                            }
                                            submenu = 4;
                                        }
                                        break;
                                    case 2:
                                        submenu = 4;
                                        while (submenu != 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("1 -установить здоровый цвет");
                                            Console.WriteLine("2 - установить больной цвет");
                                            Console.WriteLine("0 - выход");
                                            submenu = Convert.ToInt32(Console.ReadLine());
                                            switch (submenu)
                                            {
                                                case 1:
                                                    cat1.Color.HealthyColor = Console.ReadLine();
                                                    break;
                                                case 2:
                                                    cat1.Color.SickColor = Console.ReadLine();
                                                    break;

                                                case 0:
                                                    break;
                                            }
                                        }
                                        submenu = 4;
                                        break;

                                    case 3:
                                        while (submenu != 0)
                                        {
                                           
                                            Console.Clear();
                                            cat1.Punish();
                                            Console.WriteLine("0 для выхода);
                                            submenu = Convert.ToInt32(Console.ReadLine());
                                            break;
                                      
                                        }
                                        submenu = 4;
                                        break;

                                    case 4:
                                        while (submenu != 0)
                                        {
                                            Console.Clear();
                                            cat1.Feed();
                                            Console.WriteLine("0 для выхода");
                                            submenu = Convert.ToInt32(Console.ReadLine());
                                        }
                                        submenu = 4;
                                        break;
                                }
                            }
                        }
                        break;
                }
            }
        }
    }
}
