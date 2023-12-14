using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = {

        "Adams", "Arthur", "buchanan", "Bush", "Carter", "Cleveland",

        "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford",  "Garfield",

        "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson",

        "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley",

        "Monroe", "Nixon", "Obama", "Pierce", "Polk", "Reagan", "Roosevelt",

        "Taft", "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"};
            Console.WriteLine("Введите искомую строку");
            string text = Console.ReadLine();
            Console.WriteLine("Укажите длинну");
            int length = Convert.ToInt32(Console.ReadLine());
            if (CheckContains(names, text) == true)
            {
                Console.WriteLine("Все строки коллекции совпадают со строкой");
            }
            else
            {
                Console.WriteLine("Не все строки коллекции совпадают со строкой");
            }
            if (CheckContains2(names, text) == true)
            {
                Console.WriteLine("Есть коллекции которые совпадают со строкой");
                CheckContains3(names, text);
            }
            else
            {
                Console.WriteLine("Нету коллекций которые совпадают со строкой");
            }

            if (CheckStarts(names, text) == false)
            {
                Console.WriteLine("Не все строки начинаются с заданной строки");
            }
            else
            {
                Console.WriteLine("Все строки начинаются с заданной строки");
            }
            if (CheckStarts2(names, text) == true)
            {
                Console.WriteLine("Есть строки которые начинаются с заданной");
                CheckStarts3(names, text);
            }
            else
            {
                Console.WriteLine("Таких строк нету");
            }
           
            if (CheckEnds(names, text) == false)
            {
                Console.WriteLine("Не все строки заканчиваются на заданную строчку");
            }
            else
            {
                Console.WriteLine("Все строчки заканчиваются на заданную");
            }
            if (CheckEnds2(names, text) == true)
            {
                Console.WriteLine("Есть строчки которые заканчиваются на данную");
                Lalala(names, text);
            }
            else
            {
                Console.WriteLine("Таких строк нету");
            }
            if (CheckLength(names,length) == true)
            {
                Console.WriteLine("Длинна всех строк не превосходит заданную строку");
            }
            else
            {
                Console.WriteLine("Длинна всех строк превосходит заданную строку");
            }
            if (CheckLength(names, length) == true)
            {
                Console.WriteLine("Есть строки которые больше указанной длины");
                CheckLength3(names,length);
            }
            else
            {
                Console.WriteLine("Все строки меньше указанной длинны");
            }
        }
        /// <summary>
        /// определить все ли строки коллекции, совпадают с  заданной  строкой
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        private static bool CheckContains(string[] names, string text)
        {

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] != text)
                {
                    return false;
                }



            }
            return true;
        }
        /// <summary>
        /// определить есть ли строки коллекции, совпадающие с  заданной  строкой
        /// </summary>
        /// <param name="names"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private static bool CheckContains2(string[] names, string text)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == text)
                {
                    return true;
                }

            }
            return false;
        }
        /// <summary>
        /// вывести все строки коллекции, которые совпадают с  заданной  строкой
        /// </summary>
        /// <param name="names"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private static void CheckContains3(string[] names, string text)
        {
            int count = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == text)
                {
                    Console.WriteLine(names[i]);
                    
                }
            }
        }
        /// <summary>
        /// определить все ли строки, начинаются с заданной строки
        /// </summary>
        /// <param name="names"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private static bool CheckStarts(string[] names, string text)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (!names[i].StartsWith(text))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// определить есть ли строки, которые начинаются с заданной строки
        /// </summary>
        /// <param name="names"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private static bool CheckStarts2(string[] names, string text)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].StartsWith(text))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// вывести все строки, которые начинаются с заданной строки
        /// </summary>
        /// <param name="names"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private static void CheckStarts3(string[] names, string text)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].StartsWith(text))
                {
                    Console.WriteLine(names[i]);
                }
            }
           
        }
        /// <summary>
        /// определить все ли строки, заканчиваются с заданной строки
        /// </summary>
        /// <param name="names"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private static bool CheckEnds(string[] names, string text)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (!names[i].EndsWith(text))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// определить есть ли строки, которые начинаются с заданной строки
        /// </summary>
        /// <param name="names"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private static bool CheckEnds2(string[] names, string text)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].EndsWith(text))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// вывести все строки, которые начинаются с заданной строки
        /// </summary>
        /// <param name="names"></param>
        /// <param name="text"></param>
        private static void Lalala(string[] names, string text)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].EndsWith(text))
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
        /// <summary>
        /// определить длина всех ли строк превосходит указанную длину
        /// </summary>
        /// <param name="names"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private static bool CheckLength(string[] names, int length)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names.Length < length)
                {
                    return false;
                }
            }
            return false;
        }
        /// <summary>
        /// определить есть ли строки, длина которых превосходит указанную длину
        /// </summary>
        /// <param name="names"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private static bool CheckLength2(string[] names, int length)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > length)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// вывести все строки, длина которых  превосходит указанную длину
        /// </summary>
        /// <param name="names"></param>
        /// <param name="text"></param>
        private static void CheckLength3(string[] names, int length)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > length)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}
