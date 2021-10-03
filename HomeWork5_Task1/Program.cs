using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork5_Task1
{
    /* Щукин Андрей 
     * 1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) **с использованием регулярных выражений.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LoginCheckingSimple("gfd55Dgfg"));

            Console.WriteLine(LoginCheckingRegular("whw6w23kl0"));

            Console.ReadLine();
        }

        static bool LoginCheckingSimple(string input)
        {
            bool result = false;
            int length = input.Length;

            if (length >= 2 && length <= 10) //проверка длины
            {
                if (!char.IsDigit(input[0])) //проверка первого символа
                {
                    for (int i = 1; i < length; i++) //проверка следующих символов
                    {
                        if (char.IsDigit(input[i]) || ((input[i] < 'z') && input[i] > 'a') || ((input[i] < 'Z') && input[i] > 'A')) result = true;
                    }
                }
            }
            return result;
        }

        static bool LoginCheckingRegular(string input)
        {
            Regex regex01 = new Regex("^[^0-9]{1}[a-zA-Z0-9]{1,9}$"); //вроде работает =)
            return regex01.IsMatch(input);
        }
    }
}
