using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Квадратный корень");
            Console.WriteLine("7. Найти 1 процент");
            Console.WriteLine("8. Факториал");
            Console.WriteLine("9. Выйти из программы");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
                continue;
            }

            double num1, num2;
            double result = 0;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите первое число:");
                    num1 = GetNumberFromUser();
                    Console.WriteLine("Введите второе число:");
                    num2 = GetNumberFromUser();
                    result = num1 + num2;
                    break;
                case 2:
                    Console.WriteLine("Введите первое число:");
                    num1 = GetNumberFromUser();
                    Console.WriteLine("Введите второе число:");
                    num2 = GetNumberFromUser();
                    result = num1 - num2;
                    break;
                case 3:
                    Console.WriteLine("Введите первое число:");
                    num1 = GetNumberFromUser();
                    Console.WriteLine("Введите второе число:");
                    num2 = GetNumberFromUser();
                    result = num1 * num2;
                    break;
                case 4:
                    Console.WriteLine("Введите первое число:");
                    num1 = GetNumberFromUser();
                    Console.WriteLine("Введите второе число:");
                    num2 = GetNumberFromUser();
                    if (num2 == 0)
                    {
                        Console.WriteLine("Деление на ноль невозможно.");
                        continue;
                    }
                    result = num1 / num2;
                    break;
                case 5:
                    Console.WriteLine("Введите число:");
                    num1 = GetNumberFromUser();
                    Console.WriteLine("Введите степень:");
                    int power;
                    if (!int.TryParse(Console.ReadLine(), out power))
                    {
                        Console.WriteLine("Некорректный ввод степени.");
                        continue;
                    }
                    result = Math.Pow(num1, power);
                    break;
                case 6:
                    Console.WriteLine("Введите число:");
                    num1 = GetNumberFromUser();
                    if (num1 < 0)
                    {
                        Console.WriteLine("Квадратный корень из отрицательного числа нельзя извлечь.");
                        continue;
                    }
                    result = Math.Sqrt(num1);
                    break;
                case 7:
                    Console.WriteLine("Введите число:");
                    num1 = GetNumberFromUser();
                    result = num1 / 100;
                    break;
                case 8:
                    Console.WriteLine("Введите число:");
                    num1 = GetNumberFromUser();
                    result = CalculateFactorial(num1);
                    break;
                case 9:
                    Console.WriteLine("Выход из программы.");
                    return;
                default:
                    Console.WriteLine("Неправильный выбор. Попробуйте еще раз.");
                    break;
            }

            Console.WriteLine("Результат: " + result);
        }
    }

    static double GetNumberFromUser()
    {
        double number;
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз:");
        }
        return number;
    }

    static double CalculateFactorial(double num)
    {
        if (num == 0)
        {
            return 1;
        }
        double factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}