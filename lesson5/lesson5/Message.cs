using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.	Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
//а) Вывести только те слова сообщения,  которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.



namespace lesson5
{
    public static class Message
    {
        /// <summary>
        /// Вывести только те слова сообщения,  которые содержат не более n букв.
        /// </summary>
        public static void PunktA(StringBuilder a)
        {
            //Console.WriteLine("Введите строку: ");
            //StringBuilder a = new StringBuilder(Console.ReadLine());
            //Console.WriteLine("Исходная строка: " + a);

            Console.WriteLine("Введите количество символов в слове:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < a.Length;)
                if (char.IsPunctuation(a[i])) a.Remove(i, 1);
                else ++i;
            string str = a.ToString();
            string[] s = str.Split(' ');

            Console.WriteLine("Искомые слова: ");

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i].Length==n) Console.WriteLine(s[i]);
            }

        }

        /// <summary>
        /// Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        /// </summary>

        public static void PunktB(StringBuilder a)
        {
            //Console.WriteLine("Введите строку: ");
            //StringBuilder a = new StringBuilder(Console.ReadLine());

            Console.WriteLine("Введите последний символ в слове(слова с этим символом будут удалены):");
            char n =Convert.ToChar(Console.ReadLine());
            string empty = String.Empty;

            for (int i = 0; i < a.Length;)
                if (char.IsPunctuation(a[i])) a.Remove(i, 1);
                else ++i;
            string str = a.ToString();
            string[] s = str.Split(' ');

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i][s[i].Length - 1] == n) a.Replace(s[i], empty);
            }

            Console.WriteLine(a);

        }

        /// <summary>
        /// Найти самое длинное слово сообщения.
        /// </summary>

        public static void PunktC(StringBuilder a)
        {
            //Console.WriteLine("Введите строку: ");
            //StringBuilder a = new StringBuilder(Console.ReadLine());

            string maxstr = String.Empty;

            for (int i = 0; i < a.Length;)
                if (char.IsPunctuation(a[i])) a.Remove(i, 1);
                else ++i;
            string str = a.ToString();
            string[] s = str.Split(' ');

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i].Length > maxstr.Length) maxstr=s[i];
            }

            Console.WriteLine($"Самое длинное слово: {maxstr}");

        }

        /// <summary>
        /// Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        /// </summary>

        public static void PunktG(StringBuilder a)
        {
            //Console.WriteLine("Введите строку: ");
            //StringBuilder a = new StringBuilder(Console.ReadLine());

            string maxstr = String.Empty;

            StringBuilder b = new StringBuilder();

            for (int i = 0; i < a.Length;)
                if (char.IsPunctuation(a[i])) a.Remove(i, 1);
                else ++i;
            string str = a.ToString();
            string[] s = str.Split(' ');

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i].Length >= maxstr.Length)
                {
                    maxstr = s[i];
                    b = b.Append(maxstr);
                }

            }

            Console.WriteLine($"Cтрока с помощью StringBuilder из самых длинных слов сообщения: {b}");

        }
    }
}
