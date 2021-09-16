using MyLibrary;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            //MySampleClass mySampleClass = new MySampleClass();

            char[] chars = new[]
            {
                'j',
                '\u006A',
                (char)106
            };

            Console.WriteLine(string.Join("\t", chars));

            char c = '1';
            Console.WriteLine(char.IsLower(c));
            Console.WriteLine(char.IsUpper(c));
            
            char[] arr = new char[] { '1', 's', 'А', '+', '$' };
            for (int i = 0; i < arr.Length; i++)
            {
                UnicodeCategory category = char.GetUnicodeCategory(arr[i]);
                switch (category)
                {
                    case UnicodeCategory.UppercaseLetter:
                        Console.WriteLine($"{arr[i]} - буква в верхнем регистре.");
                        break;
                    case UnicodeCategory.LowercaseLetter:
                        Console.WriteLine($"{arr[i]} - буква в нижнем регистре.");
                        break;
                    case UnicodeCategory.DecimalDigitNumber:
                        Console.WriteLine($"{arr[i]} - число.");
                        break;
                    case UnicodeCategory.MathSymbol:
                        Console.WriteLine($"{arr[i]} - математический символ.");
                        break;
                    default:
                        Console.WriteLine($"{arr[i]} - Другое");
                        break;
                }
            }

            
            string aa = "sdfsdfdsf";

            aa += "rttt";

            Console.WriteLine(aa);

            Console.ReadKey();

        }
    }
}
