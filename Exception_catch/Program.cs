using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_catch
{
    class Program
    {
        /*
        С одним оператором try можно связать несколько операторов catch. 
        На практике это делается довольно часто. 
        Но все операторы catch должны перехватывать исключения разного типа
        */
        static void Main()
        {
            try
            {
                Console.Write("Введите число типа byte: ");
                byte b = byte.Parse(Console.ReadLine());

                int[] myArr = new int[5] { 1, 2, 0, 10, 12 };
                Console.WriteLine("Исходный массив: ");

                for (int j = 0; j <= myArr.Length; j++)
                    Console.WriteLine("{0}\t", myArr[j]);

                int i = 120;
                Console.WriteLine("\nДелим на число: \n");
                foreach (int d in myArr)
                    Console.WriteLine(i / d);
            }
            // Обрабатываем исключение, возникающее  при арифметическом переполнении
            catch (OverflowException)
            {
                Console.Write("Данное число не входит в диапазон 0 - 255");
            }
            // Исключение при делении на 0
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на ноль нельзя");
            }
            // Исключение при переполнении массива
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Индекс выходит за пределы\n");
            }

            Console.ReadLine();
        }
    }
}
