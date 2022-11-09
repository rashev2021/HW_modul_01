using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_modul_01
{
    internal class Class3
    {

        string value;

        public Class3(int[] arr)
        {
            StringBuilder s = new StringBuilder(arr.Length);

            foreach (var i in arr)
            {
                s.Append(i.ToString());
                value = s.ToString();
            }
        }

        public void Print()
        { 
            Console.WriteLine($" Число: {value} ");

            Menu menu = new Menu();
            Console.WriteLine(" Нажмите любую клавишу чтобы вернуться в меню: ");
            Console.ReadKey();
            Console.Clear();
            menu.Menu1();
        }
    }
}
