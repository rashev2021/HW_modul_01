using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_modul_01
{
    internal class Class1
    {
      
        private int _num;

        public Class1(int num)
        {
            _num = num;
        }
        static void MenuExit()
        {
            Menu menu = new Menu();
            Console.Write(" Нажмите любую клавишу чтобы вернуться в меню: ");
            Console.ReadKey();
            Console.Clear();
            menu.Menu1();
        }
        public void Print()
        {
            if (_num > 100)
            {
               Console.WriteLine("\n Ошибка. Введенно неверное значение или число больше 100\n");
               MenuExit();
               return;
            }
            if (_num % 5 != 0 && _num % 3 != 0)
            {
                if(_num <= 9)
                {
                    Console.WriteLine(" Цифра " + _num + " не кратна 3 и 5\n");
                    MenuExit();
                    return;
                }
                else
                {
                    Console.WriteLine(" Число " + _num + " не кратно 3 и 5\n");
                    MenuExit();
                    return;
                }
            }
            if (_num % 3 == 0 && _num % 5 == 0)
            {
                Console.WriteLine(" Fizz Buzz\n");
                MenuExit();
                return;
            }
            if (_num % 3 == 0)
            {
                Console.WriteLine(" Fizz\n");
                MenuExit();
                return;
            }
            if (_num % 5 == 0)
            {
                Console.WriteLine(" Buzz\n");
                MenuExit();
                return;
            }
        }
    }
   
}
