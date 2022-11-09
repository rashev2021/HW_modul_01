using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_modul_01
{
    internal class Class6
    {
        private int _t, _z, _s;
        

        public Class6(int temp, int z)
        {
            _t = temp;
            _z = z;
        }

        public void Print()
        {
            if (_z == 1)
            {
                _s = (_t - 32) * 5 / 9;

                Console.WriteLine($"\n по F: {_t} градусов\n по C: {_s} градусов");
            }

            else
            {
                _s = (_t * 9 / 5) + 32;

                Console.WriteLine($"\n по F: {_t} градусов\n по C: {_s} градусов");
            }

            Menu menu = new Menu();
            Console.WriteLine("\n Нажмите любую клавишу чтобы вернуться в меню: ");
            Console.ReadKey();
            Console.Clear();
            menu.Menu1();

        }
    }
}
