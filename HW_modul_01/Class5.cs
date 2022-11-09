using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace HW_modul_01
{
  
    internal class Class5
    {

        private int _d, _m, _y;

        public Class5(int day, int month, int year)
        {
            _d = day;
            _m = month;
            _y = year;
        }

        public void Print()
        {
            Console.WriteLine($"\n день: {_d}, месяц: {_m}, год: {_y}\n");

            if (_m == 12 || _m == 01 || _m == 1 || _m == 02 || _m == 2)
            {
                Console.WriteLine(" Winter Wednesday");
            }
            if (_m == 03 || _m == 3 || _m == 04 || _m == 4 || _m == 05 || _m == 5)
            {
                Console.WriteLine(" Spring Wednesday");
            }
            if (_m == 06 || _m == 6 || _m == 07 || _m == 7 || _m == 08 || _m == 8)
            {
                Console.WriteLine(" Summer Wednesday");
            }
            if (_m == 09 || _m == 9 || _m == 10 || _m == 11)
            {
                Console.WriteLine(" Autumn Wednesday");
            }

            Menu menu = new Menu();
            Console.WriteLine("\n Нажмите любую клавишу чтобы вернуться в меню: ");
            Console.ReadKey();
            Console.Clear();
            menu.Menu1();
        }
    }
}
