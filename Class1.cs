using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_1
{
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
}
