using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp02
{


    class Message
    {

        private static string[] separators = { ",", ".", "?", ";", ":", " " };

        public static void PrintWords(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 3 && words[i][0] == words[i][words[i].Length - 1])
                {
                    Console.WriteLine(words[i]);
                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {


            string str01;
            str01 = "Hello!";
            string str02 = "Hello, GeekBrains!";
            string str03 = new string(new char[] { 'H', 'i', '!' });

            string s1 = "Sample";
            string s2 = "Sample";
            string s5 = "sample";

            //s2[0] = 'a';
 


            string s3 = new string(new char[] { 'H', 'i', '!' });
            string s4 = new string(new char[] { 'H', 'i', '!' });

            Console.WriteLine($"s3 vs s4: { s3 == s4 }");
            //Console.WriteLine($"s3 vs s4: { s3 > s4 }");
            Console.WriteLine($"s3 vs s4: { s3.Equals(s4) }");


            Console.WriteLine($"s3 vs s4: { s2.CompareTo(s5) }");
            Console.WriteLine($"s3 vs s4: { string.Compare(s5, s2) }");


            string message = "За окном потоп, а я ем торт.";

            Message.PrintWords(message);

            StringBuilder stringBuilder01 = new StringBuilder();
            Console.WriteLine(stringBuilder01.Capacity);
            StringBuilder stringBuilder02 = new StringBuilder(message);
            StringBuilder stringBuilder03 = new StringBuilder(1000);
            Console.WriteLine(stringBuilder03.Length);
            stringBuilder03.Append("Hello!");
            stringBuilder03.Append("\tHello!");
            stringBuilder03.Append("\tHello!");
            Console.WriteLine(stringBuilder03.ToString());

            stringBuilder02.Append(" Очень холодно.");
            stringBuilder02.Insert(3, "огромным ");
            stringBuilder02.Replace("торт", "бутерброд");
            stringBuilder02.Replace("бутерброд", "");
            stringBuilder02.Remove(3, 9);

            Console.WriteLine(stringBuilder02.ToString());

            Console.ReadLine();

        }
    }
}
