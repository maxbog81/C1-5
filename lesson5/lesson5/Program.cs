using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Богатов Максим

namespace lesson5
{
    class Program
    {

        static void Main(string[] args)
        {
            //1.Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, 
            //содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
            //а) без использования регулярных выражений;

            bool flag;
            Console.WriteLine("Введите логин: ");
            string login = Console.ReadLine();

            try
            {
                // Проверка на длину
                if (login.Length < 2 || login.Length > 10)
                    throw new ArgumentException("Не корректная длина логина");

                // Проверка первого символа на цифру
                if (Char.IsDigit(login[0]))
                    throw new ArgumentException("Не корректный первый символ логина");

                for (int i = 0; i < login.Length; i++)
                {
                    if (!Char.IsLetterOrDigit(login[i]))
                        throw new ArgumentException("Не корректный логин");

                    if (((login[i] >= 'a') && (login[i] <= 'z')) || ((login[i] >= 'A') && (login[i] <= 'Z')) || ((login[i] >= '0') && (login[i] <= '9')))
                        flag = true;
                    else
                        throw new ArgumentException("Не корректный логин"); ;

                }

                Console.WriteLine("Корректный логин");
            }

            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception)
            {
                Console.WriteLine("Не корректный логин");
            }
           //finally
           // {
           //     Console.ReadKey();
           // }

            //б) **с использованием регулярных выражений.

            Console.WriteLine("Введите логин: ");
            string login1 = Console.ReadLine();

                Regex login_regex = new Regex(@"^[a-zA-Z][a-zA-Z0-9]{1,9}$");

                if (login_regex.IsMatch(login1)) 
                {
                Console.WriteLine("Корректный логин");
            }
                else
                {
                Console.WriteLine("Не корректный логин");
            }

                Console.ReadKey();

            //2.	Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            //а) Вывести только те слова сообщения,  которые содержат не более n букв.
            //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            //в) Найти самое длинное слово сообщения.
            //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.

            try
            {
                Console.WriteLine("Введите строку: ");
                StringBuilder a = new StringBuilder(Console.ReadLine());

                Message.PunktA(a);
                Message.PunktB(a);
                Message.PunktC(a);
                Message.PunktG(a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.ReadKey();
            }
        }
    }
}