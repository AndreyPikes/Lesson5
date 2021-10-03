using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_Task2
{
    /*Щукин Андрей
     * 2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения, которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, 
    в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.*/
    class Program
    {
        static void Main(string[] args)
        {
            #region А)
            Console.WriteLine("А) Введите строку, разделяя слова");
            string input1 = Console.ReadLine();

            Console.WriteLine("Введите максимальную длину слова");
            int maxLength = int.Parse(Console.ReadLine());

            Message.WordShoterThan(maxLength, input1);
            #endregion

            #region Б) 
            Console.WriteLine("Б) Введите строку, разделяя слова");
            string input2 = Console.ReadLine();

            Console.WriteLine("Введите последний символ слова");
            char endingChar = char.Parse(Console.ReadLine());

            Message.DeleteEndingWords(endingChar, ref input2);
            Console.WriteLine(input2);
            #endregion

            #region В) 
            Console.WriteLine("В) Введите строку, разделяя слова");
            string input3 = Console.ReadLine();

            string[] longestWords1 = Message.SearchLongestWordsStringArray(input3);
            Console.WriteLine(String.Join(" ", longestWords1));
            #endregion

            #region Г)
            StringBuilder longestWords2 = Message.SearchLongestWordsStringBuilder(input3);

            Console.WriteLine(longestWords2);
            #endregion

            #region Д)
            string[] searchingWords = new string[] { "дом", "крыша", "фундамент" };

            string inputString = "дом крыша, дом. дом фундамент, стена крыша дом";

            Dictionary<string, int> dict = Message.FrequencyDictionary(searchingWords, inputString);

            Console.WriteLine($"В строке \"{inputString}\"");
            foreach (KeyValuePair<string, int> e in dict)
            {

                Console.WriteLine($"слово \"{e.Key}\" содержится {e.Value} раз");
            }
            #endregion
            Console.ReadKey();
        }
    }
}