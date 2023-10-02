using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Игра 'Угадай число'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("0. Выход");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PlayGuessNumber();
                    break;
                case 2:
                    PrintMultiplicationTable();
                    break;
                case 3:
                    PrintDivisors();
                    break;
                case 0:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void PlayGuessNumber()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);
        int guess;
        int attempts = 0;

        Console.WriteLine("Игра 'Угадай число'");
        Console.WriteLine("Я загадал число от 0 до 100. Попробуйте угадать!");

        do
        {
            Console.Write("Введите число: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess < randomNumber)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Загаданное число меньше.");
            }
            else
            {
                Console.WriteLine("Поздравляю! Вы угадали число {0} за {1} попыток.", randomNumber, attempts);
            }
        } while (guess != randomNumber);
    }

    static void PrintMultiplicationTable()
    {
        Console.WriteLine("Таблица умножения:");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("{0,4}", i * j);
            }
            Console.WriteLine();
        }
    }

    static void PrintDivisors()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Делители числа {0}:", number);

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
