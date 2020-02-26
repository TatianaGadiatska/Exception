using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception__Data
{
    class Program
    {
        /*
         *Доступное в классе System.Exception свойство Data позволяет заполнять объект исключения 
         * соответствующей вспомогательной информацией (например, датой и временем возникновения исключения).
         */
        static void Main()
        {
            try
            {
                Console.Write("Введите x: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Введите y: ");
                int y = int.Parse(Console.ReadLine());

                // Создаем локальную переменную для получения свойства HelpLink
                Exception exc = new Exception();
                // Вставка специальных дополнительных данных имеющих отношение к ошибке
                exc.Data.Add("Время возникновения: ", DateTime.Now);
                exc.Data.Add("Причина: ", "Некорректное значение");
                throw exc;

                int result = x/y;
                Console.WriteLine("Результат: " + result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n*** Error! ***\n--------------\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("ОШИБКА: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(ex.Message + "\n\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Метод: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(ex.TargetSite + "\n\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Вывод стека: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(ex.StackTrace + "\n\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(ex.HelpLink + "\n\n");
                Console.ForegroundColor = ConsoleColor.Green;
                if (ex.Data != null)
                {
                    Console.WriteLine("Сведения: \n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    foreach (DictionaryEntry d in ex.Data)
                        Console.WriteLine("-> {0} {1}", d.Key, d.Value);
                    Console.WriteLine("\n\n");
                }
                Main();
            }
            Console.ReadLine();
        }
    }
}