using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_modul_01
{
    internal class Class4
    {

        private int _e, _f, _g, _k, _c;
        int[] arr = new int[6];
        string value;

        public Class4(int e, int f, int g)
        {
            _e = e;
            _f = f;
            _g = g;
            _k = e;

            for(int i = 5; i >= 0; i--)
            {
                arr[i] = _e % 10;
                _e /= 10;
            }

            _c = arr[_f - 1];
            arr[_f - 1] = arr[_g - 1];
            arr[_g - 1] = _c;

            StringBuilder s = new StringBuilder(arr.Length);

            foreach (var i in arr)
            {
                s.Append(i.ToString());
                value = s.ToString();
            }
        }

        public void Print()
        {
            Console.WriteLine($"\n Введенное число {_k}");
            Console.WriteLine($" Замена эллементов местами по индексу {_f} с индексом {_g} :  {value} \n");
            Menu menu = new Menu();
            Console.WriteLine(" Нажмите любую клавишу чтобы вернуться в меню: ");
            Console.ReadKey();
            Console.Clear();
            menu.Menu1();
        }
    }
  
}
