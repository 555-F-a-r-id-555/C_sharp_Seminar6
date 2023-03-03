using System;
// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] inputNumbers(int length)
{
    int m = length;
    int[] array = new int[m];
    for (int i = 0; i < m; i++) array[i] = Convert.ToInt16(Console.ReadLine());
    return array;
}

void zeroMax(int length)
{
    int m = length;
    int[] newArray = inputNumbers(length);
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        if (newArray[i] > 0) count++;
    }
    Console.WriteLine($"[{string.Join(", ", newArray)}] -> zeroMax = {count}");
}


zeroMax(5);