using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_
{
    /*
     Один блок try может быть вложен в другой. 
     Исключение, генерируемое во внутреннем блоке try и не перехваченное в соответствующем блоке catch, 
     передается во внешний блок try
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            try
            {
                int i = int.Parse(Console.ReadLine());
                int[] myArr = new int[i];
                Console.WriteLine("\nВведите теперь элементы массива: ");
                for (int j = 0; j < i; j++)
                {
                    Console.Write("{0}й элемент: ", j + 1);
                    // Вложенный оператор try
                    try
                    {
                        myArr[j] = int.Parse(Console.ReadLine());
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Слишком большое число");
                    }
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("ОШИБКА: " + ex.Message);
            }
            /*
             Во вложенном операторе try не определяется исключение для нарушения формата ввода элементов массива, 
             но при этом, данное исключение перехватывается внешним блоком try.
             Количество вложенных операторов try не ограничено.
             */
            Console.ReadLine();
        }
    }
}
