using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            if (CheckCode(text) == true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            using(StreamWriter sw=new StreamWriter("result.txt"))
            {
                sw.WriteLine(CheckCode(text));
            }
        }

        private static bool CheckCode(string text)
        {
            double sum = 0;
            if (!(String.IsNullOrEmpty(text)))
            {
                if (text.Length == 10)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        sum += Char.GetNumericValue(text[i]);
                    }
                    if (sum % 10 == 0 && text[9] == '0')
                    {
                        return true;
                    }
                    if (sum % 3 == 0 && text[9] == '1')
                    {
                        return true;
                    }
                    if (text[9] == '9')
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

           
        }
    }
       
    }

