using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_All
{
    class Program
    {
        //Перехват всех исключений
        static void Main(string[] args)
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
            // Обрабатываем все исключения
            catch
            {
                Console.WriteLine("Возникла непредвиденная ошибка");
            }
            /*
             *В подавляющем большинстве случаев "универсальный" обработчик исключений не применяется. 
             * Как правило, исключения, которые могут быть сгенерированы в коде, обрабатываются по отдельности. 
             * Неправильное использование "универсального" обработчика может привести к тому, что ошибки, 
             * перехватывавшиеся при тестировании программы, маскируются. Кроме того, 
             * организовать надлежащую обработку всех исключительных ситуаций в одном обработчике не так-то просто. 
             */
            Console.ReadLine();
        }
    }
}
