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

    public class IntInputValidator
    {
        public static int GetValidIntInput()
        {
            int result;
            while (true)
            {
                Console.Write("Введите значение: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Ошибка! Неверное значение. Попробуйте снова.");
                }
            }
        }
    }

    public class TwoChars
    {
        protected char firstChar;
        protected char secondChar;

        // Конструктор по умолчанию
        public TwoChars()
        {
            firstChar = 'A';
            secondChar = 'B';
        }

        // Конструктор с параметрами
        public TwoChars(char first, char second)
        {
            firstChar = first;
            secondChar = second;
        }

        // Конструктор копирования
        public TwoChars(TwoChars source)
        {
            firstChar = source.firstChar;
            secondChar = source.secondChar;
        }

        ~TwoChars()
        {
            Console.WriteLine($"TwoChars: деструктор (уничтожен объект с символами '{firstChar}', '{secondChar}')");
        }

        // Метод для создания строки из полей
        public string CreateStringFromFields()
        {
            return $"{firstChar}{secondChar}";
        }

        // Перегрузка ToString()
        public override string ToString()
        {
            return $"TwoChars: First='{firstChar}', Second='{secondChar}'";
        }
    }

    public class EnhancedTwoChars : TwoChars
    {
        private int weight;

        // Конструктор по умолчанию
        public EnhancedTwoChars() : base()
        {
            weight = 0;
        }

        // Конструктор с параметрами
        public EnhancedTwoChars(char first, char second) : base(first, second)
        {
            weight = first + second;
        }

        ~EnhancedTwoChars()
        {
            Console.WriteLine($"EnhancedTwoChars: деструктор (уничтожен объект с весом {weight})");
        }

        // Метод 1: Проверка, является ли вес положительным
        public bool IsWeightPositive()
        {
            return weight > 0;
        }

        // Метод 2: Изменение веса на указанное значение
        public void IncreaseWeight(int amount)
        {
            weight += amount;
        }

        public override string ToString()
        {
            return $"Weight='{weight}'";
        }
    }
}
