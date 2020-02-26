using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Введите x: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Введите y: ");
                int y = int.Parse(Console.ReadLine());

                int result = x/y;
                Console.WriteLine("Результат: " + result);
            }
            // Обрабатываем исключение возникающее при делении на ноль
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Деление на 0 detected!!!\n");
                Console.WriteLine("ОШИБКА: " + ex.Message + "\n\n");
                Main();
            }
            // Обрабатываем исключение при некорректном вводе числа в консоль
            catch (FormatException ex)
            {
                Console.WriteLine("Это НЕ число!!!\n");
                Console.WriteLine("ОШИБКА: " + ex.Message + "\n\n");
                Main();
            }

            Console.ReadLine();
        }
    }
    }

