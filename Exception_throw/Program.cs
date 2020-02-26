using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_throw
{
    class Program
    {
        //Исключение может быть сгенерировано вручную с помощью оператора throw
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            byte j;
            try
            {
                if (i > 255)
                    // Генерируем исключение
                    throw new OverflowException();
                else
                    j = (byte)i;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Возникло переполнение");
            }

            Console.ReadLine();
        }
    }
}
