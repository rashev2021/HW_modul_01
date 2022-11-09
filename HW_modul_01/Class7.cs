using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_modul_01
{
    internal class Class7
    {
        private int _n1, _n2;

        public Class7(int n1, int n2)
        {
            _n1 = n1;
            _n2 = n2;
        }

        public void Print()
        {
            if (_n1 > _n2)
            {
                Console.WriteLine();
                for (int i = _n2; i <= _n1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($" {i}  ");
                    }

                }

            }
            else
            {
                Console.WriteLine();
                for (int i = _n1; i <= _n2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($" {i}  ");
                    }

                }
            }

            Menu menu = new Menu();
            Console.Write("\n\n Нажмите любую клавишу чтобы вернуться в меню: ");
            Console.ReadKey();
            Console.Clear();
            menu.Menu1();
        }
    }
}
