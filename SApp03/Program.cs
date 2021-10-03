using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SApp03
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex00 = new Regex("[a-z]"); //проверка существет ли хотя бы один

            Regex regex000 = new Regex("[a-z]{5}"); //проверка пять символов удовлетворяющих подряд

            Regex regex01 = new Regex("[a-zA-Z]{5,7}"); //от пяти до семи символов подряд
            Console.WriteLine(regex01.IsMatch("Hello!"));

            Regex regex02 = new Regex("[0-9][a-zA-Z]{5,7}"); //розовые действуют только на последние квадратные скобки МЯГКОЕ СООТВЕТСВИЕ
            Console.WriteLine(regex02.IsMatch("8Hello!"));

            Regex regex03 = new Regex("^[0-9][a-zA-Z]{5,7}"); //^ - начинаем с начала строки ЖЕСТКОЕ СООТВЕТСВИЕ С НАЧАЛА
            Console.WriteLine(regex03.IsMatch("8Hello!____________________"));

            Regex regex04 = new Regex("^[0-9][a-zA-Z]{5,7}$"); //$ - ЖЕСТКОЕ СООТВЕТВИЕ В КОНЦЕ
            Console.WriteLine(regex04.IsMatch("8Hello"));

            Regex regex05 = new Regex("^[а-яА-Я]{2}[ ][a-zA-Z]{2}$");
            Console.WriteLine(regex05.IsMatch("аБ XY"));

            Console.ReadKey();
        }
    }
}
