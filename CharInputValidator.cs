using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_1
{
    public class CharInputValidator
    {
        public static char GetValidCharInput()
        {
            char result;
            while (true)
            {
                Console.Write("Введите символ: ");
                string input = Console.ReadLine();

                if (char.TryParse(input, out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Ошибка! Введенное значение не является одиночным символом. Попробуйте снова.");
                }
            }
        }
    }
}
