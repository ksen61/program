double chois;
do
{
    Console.WriteLine("Выбирите программу, которую вы хотите выполнить:");
    Console.WriteLine("1. Угадай число");
    Console.WriteLine("2. Таблица умножение");
    Console.WriteLine("3. Вывод делителей числа");
    Console.WriteLine("4. Закрыть программу");
    chois = Convert.ToDouble(Console.ReadLine());
    if (chois == 4)
    {
        break;
    }

    if (chois == 1)
    {
        Random random = new Random();
        int randomNumber = random.Next(101);
        Console.WriteLine("Компьютер загадал число от 0 до 100");
        int chislo;
        do
        {
            Console.WriteLine("Введите число");
            string input = Console.ReadLine();
            if (int.TryParse(input, out chislo))
            {
                if (chislo < 0 || chislo > 100)
                {
                    Console.WriteLine("Введите число от 0 до 100");
                }
                else if (chislo < randomNumber)
                {
                    Console.WriteLine("Загаданное число больше");
                }
                else if (chislo > randomNumber)
                {
                    Console.WriteLine("Загаданное число меньше");
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное число.");
            }
        } while (chislo != randomNumber);
        Console.WriteLine("Вы угадали число");
    }
    if (chois == 2)
    {
        int[,] table = new int[9, 9];
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                table[i - 1, j - 1] = i * j;
            }
        }
        Console.WriteLine("Таблица умножения:");
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write($"{table[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
    if (chois == 3)
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Делители числа:");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите целое число.");
        }
    }

} while (chois != 4);