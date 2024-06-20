using System;

class Program
{
    static void Main()
    {
        // Создаем массив чисел
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Находим сумму элементов массива
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Вычисляем среднее арифметическое значение элементов массива
        double average = (double)sum / numbers.Length;

        // Выводим результаты на экран
        Console.WriteLine("Сумма элементов массива: " + sum);
        Console.WriteLine("Среднее арифметическое значение элементов массива: " + average);
    }
}
