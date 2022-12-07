// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2; -1, -7, 567, 89, 223-> 3

void Task41()
{
    Console.WriteLine("Программа принимет на вход числа и выводит, сколько из них больше 0. ");
    Console.Write("Введите количество чиссел, которые хотите использовать: ");
    int count = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    for (int i = 1; i <= count; i++)
    {
        Console.Write($"Введите {i}-ое число: ");
        double number = Convert.ToDouble(Console.ReadLine());
        if (number > 0) result++;
    }
    Console.WriteLine($"Количество чисел больше нуля равно {result}.");
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Task43()
{
    Console.WriteLine("Программа находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.");
    Console.Write($"Введите k1 = ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Введите b1 = ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Введите k2 = ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Введите b2 = ");
    double b2 = Convert.ToDouble(Console.ReadLine());

    if (k1 != k2)
    {
    double x = (b2 - b1) / (k1 - k2);
    double y = k1*x + b1;
    Console.WriteLine($"Точка пересечения прямых А({x},{y})");
    }
    else Console.WriteLine("Точка пересечения прямых не существует, т.к. они параллельны.");
}

Task41();
Task43();

