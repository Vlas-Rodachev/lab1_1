using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_1
{
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
