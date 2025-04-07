using lab1_1;

TwoChars fu1()
{
    while (true)
    {
        Console.WriteLine("Введите номер задания для основного класса");
        Console.WriteLine("1 - Ввести символы вручную");
        Console.WriteLine("2 - Оставить базовое значение");
        int number_problem1 = IntInputValidator.GetValidIntInput();
        if (number_problem1 == 1)
        {
            TwoChars twoChars = new TwoChars(CharInputValidator.GetValidCharInput(), CharInputValidator.GetValidCharInput());
            Console.WriteLine(twoChars.ToString());
            Console.WriteLine();
            return twoChars;
        }
        else if (number_problem1 == 2)
        {
            TwoChars twoChars = new TwoChars();
            Console.WriteLine(twoChars.ToString());
            Console.WriteLine();
            return twoChars;
        }
    }
}

EnhancedTwoChars fu2()
{
    while (true)
    {
        Console.WriteLine("Введите номер задания для дочернего класса");
        Console.WriteLine("1 - Ввести символы вручную");
        Console.WriteLine("2 - Оставить базовое значение");
        int number_problem1 = IntInputValidator.GetValidIntInput();
        if (number_problem1 == 1)
        {
            EnhancedTwoChars twoChars = new EnhancedTwoChars(CharInputValidator.GetValidCharInput(), CharInputValidator.GetValidCharInput());
            Console.WriteLine(twoChars.ToString());
            Console.WriteLine();
            return twoChars;
        }
        else if (number_problem1 == 2)
        {
            EnhancedTwoChars twoChars = new EnhancedTwoChars();
            Console.WriteLine(twoChars.ToString());
            Console.WriteLine();
            return twoChars;
        }
    }
}

TwoChars twoChars = fu1();
EnhancedTwoChars twoCharsDother = fu2();
bool tr1 = true;
while (tr1)
{
    Console.WriteLine("Введите номер задания");
    Console.WriteLine("1 - Скопировать в новый класс");
    Console.WriteLine("2 - Сделать строку из символов");
    Console.WriteLine("3 - Проверить положительный ли вес класса");
    Console.WriteLine("4 - Изменить вес класса");
    Console.WriteLine("5 - Выход");
    int number_problem = IntInputValidator.GetValidIntInput();
    if (number_problem == 1)
    {
        TwoChars twoChars1 = new TwoChars(twoChars);
        Console.WriteLine(twoChars1.ToString());
        Console.WriteLine();
    }
    else if (number_problem == 2)
    {
        Console.WriteLine(twoChars.CreateStringFromFields());
        Console.WriteLine();
    }
    else if (number_problem == 3)
    {
        Console.WriteLine(twoCharsDother.IsWeightPositive());
        Console.WriteLine();
    }
    else if (number_problem == 4)
    {
        twoCharsDother.IncreaseWeight(IntInputValidator.GetValidIntInput());
        Console.WriteLine(twoCharsDother.ToString());
        Console.WriteLine();
    }
    else if (number_problem == 5)
    {
        tr1 = false;
    }
}