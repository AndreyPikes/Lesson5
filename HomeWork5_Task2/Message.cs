using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HomeWork5_Task2
{
    public class Message
    {
        private static string[] SeparateString(string input)
        {
            string[] separators = { ",", ".", "?", ";", ":", " " };
            return input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Вывести только те слова сообщения message, которые содержат не более length букв
        /// </summary>
        /// <param name="length"></param>
        /// <param name="message"></param>
        public static void WordShoterThan(int length, string message)
        {
            string[] words = SeparateString(message);

            Console.WriteLine($"Вывожу слова не длинне {length} символов");

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= length)
                {
                    Console.WriteLine(words[i]);
                }
            }
        }

        /// <summary>
        /// Удалить из сообщения все слова, которые заканчиваются на заданный символ
        /// </summary>
        public static void DeleteEndingWords(char endingChar, ref string message)
        {
            string[] words = SeparateString(message);
            message = "";

            for (int i = 0; i < words.Length; i++)
            {
                int curentWordLength = words[i].Length;

                if (words[i][curentWordLength - 1] == endingChar)
                {
                    words[i] = "";
                }
                message += words[i] + " ";
            }
        }

        /// <summary>
        /// Найти самые длинные слова сообщения при помощи строк
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string[] SearchLongestWordsStringArray(string message)
        {
            int maxLength = 0;            

            string[] words = SeparateString(message);

            string[] result = new string[words.Length];
            int j = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxLength)
                {
                    maxLength = words[i].Length;
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == maxLength)
                {
                    result[j] = words[i];
                    j++;
                }
            }
            return result;
        }

        /// <summary>
        /// Найти самые длинные слова сообщения при помощи StringBuilder
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static StringBuilder SearchLongestWordsStringBuilder(string message)
        {
            int maxLength = 0;

            string[] words = SeparateString(message);

            StringBuilder result = new StringBuilder(words.Length);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxLength)
                {
                    maxLength = words[i].Length;
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == maxLength)
                {
                    result.Append(words[i] + " ");
                }
            }
            return result;
        }

        /// <summary>
        /// д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
        /// </summary>
        /// <param name="wordList"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static Dictionary<string, int> FrequencyDictionary(string[] wordList, string text)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < wordList.Length; i++)
            {
                dict.Add(wordList[i], 0);
            }

            string[] words = SeparateString(text);

            for (int i = 0; i < words.Length; i++)
            {
                if (dict.ContainsKey(words[i])) dict[words[i]]++;                
            }
            return dict;
        } 
    }
}
