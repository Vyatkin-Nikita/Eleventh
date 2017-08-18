using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleventh
{
    /*
     * Программа зашифровывает и расшифровывает введённый текст.
     *  Шифрование по схеме: изменение порядка следования символов в группах (группа состоит из 4 символов) по принцыпу было 1234, стало 3241. 
     *  Если в последней группе меньше 4 символов, то добавляются пробелы.
     */
    class Program
    {
        static string EnigmaString;//Искомая строка для шифровки\расшифровки
        static string Encryption (string str)//Шифрование строки str
        {
            while (str.Length % 4 != 0 )//Если длина строки не кратна 4, то в конец добавляются пробелы
            {
                str += " ";
            }


            string NewStr = "";//Результаты шифрования записываются в эту строку
            
            for (int i = 3; i< str.Length; i+=4)//Замены символов в группах по схеме: было 1234, стало 3241
            {
                NewStr += str[i - 1];
                NewStr += str[i - 2];
                NewStr += str[i];
                NewStr += str[i - 3];
            }

            return NewStr;
        }
        static string Decryption (string str)//Расшифровка строки str
        {
            string NewStr = "";//В эту строку записываются результаты дешифровки

            for (int i = 3; i < str.Length; i += 4)//Дешифрока по схеме: было 3241, стало 1234
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
