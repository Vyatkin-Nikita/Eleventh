using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleventh
{
    class Program
    {
        static string EnigmaString;
        static string Encryption (string str)
        {
            while (str.Length % 4 != 0 )
            {
                str += " ";
            }


            string NewStr = "";
            
            for (int i = 3; i< str.Length; i+=4)
            {
                NewStr += str[i - 1];
                NewStr += str[i - 2];
                NewStr += str[i];
                NewStr += str[i - 3];
            }

            return NewStr;
        }
        static string Decryption (string str)
        {
            string NewStr = "";

            for (int i = 3; i < str.Length; i += 4)
            {
                NewStr += str[i];
                NewStr += str[i - 2];
                NewStr += str[i-3];
                NewStr += str[i-1];
            }

            return NewStr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для шифрования");
            EnigmaString = Console.ReadLine();
            Console.WriteLine();
            EnigmaString = Encryption(EnigmaString);
            Console.WriteLine("Строка после шифрования:");
            Console.WriteLine(EnigmaString+"\n");
            Console.WriteLine("Строка после расшифровки:");
            EnigmaString = Decryption(EnigmaString);
            Console.WriteLine(EnigmaString + "\n");
            Console.ReadLine();
        }
    }
}
