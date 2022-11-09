using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HW_modul_01
{
    internal class Menu
    {
        public void MenuReturn()
        {
            Console.Write("\n Введено неверное значение. Вернуться в меню, нажмите любую клавишу: ");
            Console.ReadLine();
            Console.Clear();
            Menu1();
        }
       
        public void Menu1()
        {

            Console.WriteLine(" Модуль 1\n\n Меню\n");
            Console.Write(" Задание 1 - введите [1]\n Задание 2 - введите [2]\n Задание 3 - введите [3]\n" +
                " Задание 4 - введите [4]\n Задание 5 - введите [5]\n Задание 6 - введите [6]\n Задание 7 - введите [7]\n\n Введите номер задания: ");

            char num = Console.ReadKey().KeyChar;

            switch (num)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("\n Задание 1.\n Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. \n" +
                        " Если число кратно 3 (делится на 3 без остатка) нужно вывести слово Fizz. \n" +
                        " Если число кратно 5 нужно вывести слово Buzz. Если число кратно 3 и 5 нужно вывести Fizz Buzz.\n" +
                        " Если число не кратно не 3 и 5 нужно вывести само число.\n" +
                        " Если пользователь ввел значение не в диапазоне от 1 до 100 требуется вывести сообщение об ошибке.\n");
                    Console.Write(" Введите число от 1 до 100: ");

                    try
                    {
                        int b = int.Parse(Console.ReadLine());
                        Class1 class1 = new Class1(b);
                        class1.Print();
                    }
                    catch
                    {
                      MenuReturn(); 
                    }
                  
                    break;

                case '2':
                    Console.Clear();
                    Console.WriteLine("\n Задание 2.\n" +
                        " Пользователь вводит с клавиатуры два числа. \n" +
                        " Первое число — это значение, второе число процент, который необходимо посчитать\n");
                    Console.Write(" Введите первое число (значение): ");

                    try
                    {
                        int c = int.Parse(Console.ReadLine());
                        Console.Write(" Введите второе число (процент): ");
                        int d = int.Parse(Console.ReadLine());

                        Class2 class2 = new Class2(c,d);
                        class2.Print();
                    }
                    catch
                    {
                        MenuReturn();
                    }
                  
                    break;

                case '3':
                    Console.Clear();
                    Console.WriteLine("\n Задание 3.\n" +
                        " Пользователь вводит с клавиатуры четыре цифры.\n" +
                        " Необходимо создать число, содержащее эти цифры\n");
                   
                    try
                    {

                        int[] arr  = new int[4];
                        for (int i = 0; i < arr.Length; i++)
                        {
                         
                            Console.Write($" Введите {i + 1} цифру: ");
                            arr[i] = int.Parse(Console.ReadLine());
                        }

                        Class3 class3 = new Class3(arr);
                        class3.Print();
                    }
                    catch
                    {
                        MenuReturn();
                    }

                    break;

                case '4':
                    Console.Clear();
                    Console.WriteLine("\n Задание 4.\n" +
                        " Пользователь вводит шестизначное число.\n" +
                        " После чего пользователь вводит номера разрядов для обмена цифр\n");
                    Console.Write(" Введите шестизначное число: ");
                    string str;
                    try
                    {

                        int e = int.Parse(Console.ReadLine());
                        str = e.ToString();

                        if (str.Length > 6)
                        {
                            Console.WriteLine("\n Число должно быть не больше шести символов.");
                            MenuReturn();
                            return;
                        }
                        else if (str.Length < 6)
                        {
                            Console.WriteLine("\n Число должно быть не менее шести символов.");
                            MenuReturn();
                            return;
                        }
                        else
                        {
                            Console.Write(" Введите номера разрядов для обмена цифр (Две цифры от 1 до 6.)\n" +
                                      " Первая цифра которую меняем: ");
                            int f = int.Parse(Console.ReadLine());

                             if(f > 6)
                            {
                                Console.WriteLine("\n Цифра должна быть не больше шести.");
                                MenuReturn();
                                return;
                            }
                             if(f < 6)
                            {
                                Console.WriteLine("\n Цифра должна быть не меньше шести.");
                                MenuReturn();
                                return;
                            }
                            Console.Write(" Вторая цифра с которой меняем: ");
                            int g = int.Parse(Console.ReadLine());

                            if (g > 6)
                            {
                                Console.WriteLine("\n Цифра должна быть не больше шести.");
                                MenuReturn();
                                return;
                            }
                            if (g < 6)
                            {
                                Console.WriteLine("\n Цифра должна быть не меньше шести.");
                                MenuReturn();
                                return;
                            }

                            Class4 class4 = new Class4(e, f, g);
                            class4.Print();
                        }

                    }
                    catch
                    {
                        MenuReturn();
                    }

                    break;

                case '5':
                    Console.Clear();
                    Console.WriteLine("\n Задание 5.\n" +
                        " Пользователь вводит с клавиатуры дату.\n" +
                        " Приложение должно отобразить название сезона и дня недели.\n");
                    try
                    {
                        Console.Write(" Введите день: ");
                        int day = int.Parse(Console.ReadLine());
                        if (day > 31)
                        {
                            Console.WriteLine(" Не может быть день больше 31 ");
                            MenuReturn();
                            break;
                        }
                        Console.Write(" Введите месяц: ");
                        int month = int.Parse(Console.ReadLine());
                        if (month > 12)
                        {
                            Console.WriteLine(" Не может быть месяц больше 12 ");
                            MenuReturn();
                            break;
                        }
                        Console.Write(" Введите год: ");
                        int year = int.Parse(Console.ReadLine());

                        Class5 class5 = new Class5(day, month, year);
                        class5.Print(); 

                    }
                    catch
                    {
                        MenuReturn();
                    }

                    break;

                case '6':
                    Console.Clear();
                    Console.WriteLine("\n Задание 6.\n" +
                        " Пользователь вводит с клавиатуры показания температуры.\n" +
                        " В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий или наоборот.\n");
                    Console.Write(" Введите показания температуры: ");

                    try
                    {
                        int temp = int.Parse(Console.ReadLine());
                        Console.Write(" Введите значение температуры (1 = Фаренгейты, 2 = Цельсия): ");
                        int z = int.Parse(Console.ReadLine());

                        if (z > 2)
                        {
                            MenuReturn();
                        }

                        Class6 class6 = new Class6(temp, z);
                        class6.Print();
                    }
                    catch
                    {
                        MenuReturn();
                    }
                    break;

                case '7':
                    Console.Clear();
                    Console.WriteLine("\n Задание 7.\n " +
                        " Пользователь вводит с клавиатуры два числа.\n" +
                        " Нужно показать все четные числа в указанном диапазоне.\n" +
                        " Если границы диапазона указаны неправильно требуется произвести нормализацию границ.\n");

                    try
                    {
                        Console.Write(" Введите первое число: ");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.Write(" Введите второе число: ");
                        int n2 = int.Parse(Console.ReadLine());

                        Class7 class7 = new Class7(n1, n2);
                        class7.Print();
                    }
                    catch
                    {
                        MenuReturn();
                    }

                    break;

                default:
                    MenuReturn();
                    break;
            }
        }
    }
}
