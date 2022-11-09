using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_modul_01
{
    internal class Class2
    {

        private int _c;
        private int _d;

        public Class2(int c, int d)
        {
            _c = c;
            _d = d;
        }
        
        public void Print()
        {
            float result = _c * _d / 100;
            Console.Write($" Результат:  {result} % \n");
            Menu menu = new Menu();
            Console.WriteLine(" Нажмите любую клавишу чтобы вернуться в меню: ");
            Console.ReadKey();
            Console.Clear();
            menu.Menu1();
        }
    }
}
